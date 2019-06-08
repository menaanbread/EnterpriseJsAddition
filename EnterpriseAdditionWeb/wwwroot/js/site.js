function add(a) {
    return function (b) {
        var result = 0;
        $.ajax({
            type: "GET",
            url: '/Home/Add',
            data: {
                a: a,
                b: b
            },
            dataType: "json",
            //line added to get ajax response in sync
            async: false,
            success: function (data) {
                //line added to save ajax response in var result
                result = data;
            },
            error: function () {
                alert('Error occured');
            }
        });
        //line added to return ajax response
        return result;
    }
}


$(document).ready(function () {

    $("#doTest").on("click", function () {
        
        // output 
        var first = add(1);
        var second = add(2);
        var third = add(3);

        console.log(first(1));
        console.log(first(2));
        console.log(second(2));
        console.log(second(3));
        console.log(third(3));
            
    });

});