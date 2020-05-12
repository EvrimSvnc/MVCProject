function ValidateBlogForm() {
    $("#CallbackMessageFail .alert-message").html("");
    var Blogtitle = document.forms["BlogForm"]["BlogTitle"].value;
    var BlogDescription = document.forms["BlogForm"]["BlogDescription"].value;
    var BlogType = document.forms["BlogForm"]["BlogType"].value;

    $("#CallbackMessageFail .alert-message").html("** Zorunlu alanları doldurunuz");
    $("#CallbackMessageFail .alert-message").css("color", "red");
    $("#CallbackMessageFail").fadeIn(600);
    if (Blogtitle == "" || Blogtitle == null || Blogtitle == undefined) {
        $("#BlogTitle").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#BlogTitle").removeClass("invalid-form-element-color");
    }
    if (BlogDescription == "" || BlogDescription == null || BlogDescription == undefined) {
        $("#BlogDescription").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#BlogDescription").removeClass("invalid-form-element-color");
    }
    if (BlogType == "" || BlogType == null || BlogType == undefined || BlogType == 0) {
        $("#BlogType").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#BlogType").removeClass("invalid-form-element-color");
    }

}

function ValidateCommitForm() {
    $("#CallbackMessageFail .alert-message").html("");
    var Message = document.forms["CommitForm"]["Message"].value;
    var Name = document.forms["CommitForm"]["Name"].value;
    var EMail = document.forms["CommitForm"]["EMail"].value;

    $("#CallbackMessageFail .alert-message").html("** Zorunlu alanları doldurunuz");
    $("#CallbackMessageFail .alert-message").css("color", "red");
    $("#CallbackMessageFail").fadeIn(600);
    if (Message == "" || Message == null || Message == undefined) {
        $("#Message").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#Message").removeClass("invalid-form-element-color");
    }
    if (Name == "" || Name == null || Name == undefined) {
        $("#Name").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#Name").removeClass("invalid-form-element-color");
    }
    if (EMail == "" || EMail == null || EMail == undefined) {
        $("#EMail").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#EMail").removeClass("invalid-form-element-color");
    }

}


function ValidateLoginForm() {
    $("#CallbackMessageFail .alert-message").html("");
    var Password = document.forms["LoginForm"]["Password"].value;
    var EMail = document.forms["LoginForm"]["EMail"].value;

    $("#CallbackMessageFail .alert-message").html("** Zorunlu alanları doldurunuz");
    $("#CallbackMessageFail .alert-message").css("color", "red");
    $("#CallbackMessageFail").fadeIn(600);
    if (EMail == "" || EMail == null || EMail == undefined) {
        $("#EMail").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#EMail").removeClass("invalid-form-element-color");
    }
    if (Password == "" || Password == null || Password == undefined) {
        $("#Password").addClass("invalid-form-element-color");
        return false;
    }
    else {
        $("#Password").removeClass("invalid-form-element-color");
    }
   

}
