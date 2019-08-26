$(document).ready(function () {

    var chat = $.connection.chatHub;
    chat.client.sendChat = function (name, message) {
        var divName = $("<div />").text(name).html();
        var divMessage = $("<div />").text(message).html();
        $("#discussion").append("<li class='name-chat'><strong><div class='msg-chat'><p>" + divName + ": </strong>" + divMessage + "</p></div></li>");
    };

    var nameOwner = prompt("Escribe tu nombre: ", "");
    $("#displayname").val(nameOwner);
    $("#message").focus();

    $.connection.hub.start().done(function () {
        $("#sendmessage").click(function () {
            var nameOwner = $("#displayname").val();
            var messageText = $("#message").val();
            chat.server.send(nameOwner, messageText);
            $("#message").val("").focus();
        });
        $("#message").on('keypress', function (e) {
            if (e.which == 13) {
                var nameOwner = $("#displayname").val();
                var messageText = $("#message").val();
                chat.server.send(nameOwner, messageText);
                $("#message").val("").focus();
            }
        });
    });
});