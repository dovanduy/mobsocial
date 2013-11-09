﻿Website = {};


Website.RootUrl = getRootUrl();

function getRootUrl() {
    var defaultPorts = { "http:": 80, "https:": 443 };

    var port = '';

    // Add port if specified and not one of the default ports 
    if (window.location.port && window.location.port != defaultPorts[window.location.protocol])
        port = ":" + window.location.port;
    
    var rootUrl = window.location.protocol + "//" + window.location.hostname + port;

    return rootUrl;
}


