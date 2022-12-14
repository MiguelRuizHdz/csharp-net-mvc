function jsonServerResponse(url, data, beforeSend, success, error, complete) {
    JSOoptionalData = (typeof JSOoptionalData == "undefined") ? 'defaultValue': JSOoptionalData
    var jqxhr = $.ajax({
        type: "GET",
        url,
        data,
        dataType: "json",
        cache: false,
        beforeSend,
        success,
        error,
        complete
    });
}

function jsonServerPost(url, data, beforeSend, success, error, complete) {
    JSOoptionalData = (typeof JSOoptionalData == "undefined") ? 'defaultValue': JSOoptionalData
    var jqxhr = $.ajax({
        type: "POST",
        url,
        data,
        dataType: "json",
        cache: false,
        beforeSend,
        success,
        error,
        complete
    });
}

function jsonServerPostFile(url, data, beforeSend, success, error, complete) {
    $.ajax({
        url,
        data,
        cache: false,
        contentType: false,
        proccessData: false,
        method: 'POST', // For jQuery < 1.9
        beforeSend,
        success,
        error,
        complete
    });
}