

function AjaxJsonHandler(_url, _type, _data, success_callback, error_callback)
{
    $.ajax({

        dataType: "json",			                                     //סוג הנתונים שאנחנו מצפים לקבל מהשרת
        url: _url,			                                //הכתובת לשרת ולפונקציה
        contentType: "application/json; charset=utf-8",	              //סוג הנתונים שאנחנו שולחים לשרת
        type: _type,			                        	              //סוג הפעולה		
        data: JSON.stringify(_data),			                              //הנתונים עצמם שאנחנו שולחים
        success: success_callback,
        error: error_callback
    });
}

function GenericError(err) {
    console.log(err);
}

var SystemHelper = {

    WebApiEndPoints: {
        login: "/api/Login/",
        member: "/api/Member/",
        city: "/api/City/"

    },
    HttpVerbs: {
        POST: "POST",
        GET: "GET",
        DELETE: "DELETE",
        PUT: "PUT"
    },
    Storage: {
        user: "user"
    },
    getFromStorage: function (key) {
        return JSON.parse(localStorage.getItem(key));
    }
}

function getQueryString(par) {
    var QueryStringHelper = location.search.substring(1).split('&');

    for (i in QueryStringHelper) {
        var x = QueryStringHelper[i].split("=");

        if (x[0] == par) {
            return x[1];
        }
    }

    return "";
}