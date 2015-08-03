// the semi-colon before function invocation is a safety net against concatenated
// scripts and/or other plugins which may not be closed properly.
; (function ($, window, document, undefined) {

    // undefined is used here as the undefined global variable in ECMAScript 3 is
    // mutable (ie. it can be changed by someone else). undefined isn't really being
    // passed in so we can ensure the value of it is truly undefined. In ES5, undefined
    // can no longer be modified.

    // window and document are passed through as local variable rather than global
    // as this (slightly) quickens the resolution process and can be more efficiently
    // minified (especially when both are regularly referenced in your plugin).

    // Create the defaults once
    var pluginName = "quicklaunchAccordion",
        defaults = {
            hoverInterval: 200,
            clickToSlide: false,
            expandedByDefault: false,
            collapseImage: '/_layouts/images/collapse.gif',
            expandImage: '/_layouts/images/expand.gif',
        },
        constants = {
            buttonClass: 'min',
        };

    // The actual plugin constructor
    function Plugin(element, options) {
        this.element = element;

        // jQuery has an extend method which merges the contents of two or
        // more objects, storing the result in the first object. The first object
        // is generally empty as we don't want to alter the default options for
        // future instances of the plugin
        this.options = $.extend({}, defaults, options, constants);

        this._defaults = defaults;
        this._name = pluginName;

        this.init();
    }

    Plugin.prototype = {

        init: function () {
            // Place initialization logic here       
            this.setupDefaults(this.element, this.options);
        },
        setupDefaults: function (el, options) {

            var starterImage;
            if (options.expandedByDefault && options.clickToSlide) {
                starterImage = options.collapseImage;
            }
            else {
                $("li ul", el).hide();
                starterImage = options.expandImage;
            }

            $('ul li', el).find('ul').each(function (index) {
                var $this = $(this);
                if (options.clickToSlide) {
                    $this.parent().find('a:first .menu-item-text').parent().parent().parent().prepend(['<a class=\'' + options.buttonClass + '\' style=\'float:right;\'><img src=\'' + starterImage + '\'/></a>'].join(''));
                }
                else {
                    $this.parent().find('a:first .menu-item-text').append(['<span style=\'float:right;font-size:0.8em;\'>(', $this.children().length, ')</span>'].join(''));
                }
            });
            if (options.clickToSlide === false) {
                var settings = {
                    sensitivity: 4,
                    interval: 200,
                    over: toggle,
                    out: toggle
                };

                $("ul li", el).hoverIntent(settings);
            }

            $("." + options.buttonClass).click(function () {
                //Get Reference to img
                var img = $(this).children();
                //Traverse the DOM to find the child UL node
                var subList = $(this).siblings('ul');
                //Check the visibility of the item and set the image            
                var Visibility = subList.is(":visible") ? img.attr('src', options.expandImage) : img.attr('src', options.collapseImage);
                //Toggle the UL
                subList.slideToggle();
            });

            $('li.selected').each(function (index) {
                $(this).children('ul').slideToggle();
            });
        },
    };

    toggle = function () {

        $(this).find('a:first').next().slideToggle();
    }

    // A really lightweight plugin wrapper around the constructor,
    // preventing against multiple instantiations
    $.fn[pluginName] = function (options) {
        return this.each(function () {
            if (!$.data(this, "plugin_" + pluginName)) {
                $.data(this, "plugin_" + pluginName, new Plugin(this, options));
            }
        });
    };

})(jQuery, window, document);

$(document).ready(function(){ 
    $('.side-navigation').quicklaunchAccordion({
    
        clickToSlide: true,
        expandedByDefault: false,
        collapseImage: '/Style Library/images/min_nav.png',
        expandImage: '/Style Library/images/max_nav.png'
    });
});
