// Write your JavaScript code.
// jQuery already loaded
var slSpd = 350;
$("#slide0")
    .find("button")
    .on("click", function () {
        var x = $(this).index() + 1;
        $("#slide0").animate({ left: "-400px" }, slSpd);
        $("#slide" + x).animate({ left: "0px" }, slSpd);
    });
$(".backup").on("click", function () {
    $("#slide0").animate({ left: "0px" }, slSpd);
    var x = $(this)
        .parent()
        .animate({ left: "400px" }, slSpd);
});

