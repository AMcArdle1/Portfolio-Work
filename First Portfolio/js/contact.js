"use strict";

let isValid = true;

let $ = function(id) {
    return document.getElementById(id);
}

let validateEverything = function(evt) {

    //Convert Inputs into local varables
    let fname = $("inputFName").value;
    let lname = $("inputLName").value;
    let email = $("inputEmail").value;
    let message = $("inputMessage").value;

    //Validate all input fields
    validateFName(fname);
    validateLName(lname);
    validateEmail(email);
    validateMessage(message);
    
    if (isValid == false) {
        evt.preventDefault();
    }
}

function validateFName(f) {
    if(f.trim() == "") {
        nameError();
        isValid = false;
    }
    else {
        isValid = true;
        $("name_error").innerHTML = "";
    }
}

function validateLName(l) {
    if(l.trim() == "") {
        nameError();
        isValid = false;
    }
    else {
        isValid = true;
        $("name_error").innerHTML = "";
    }
}

function validateEmail(e) {
    if(e.trim() == "") {
        emailError();
        isValid = false;
    }
    else {
        $("email_error").innerHTML = "";
        isValid = true;
    }
}

function validateMessage(m) {
    if(m.trim() == "") {
        messageError();
        isValid = false;
    }
    else {
        $("message_error").innerHTML = "";
        isValid = true;
    }
}

function nameError() {
    $("name_error").innerHTML = "Invalid Entry / Please enter your first & last name."
}

function emailError() {
    $("email_error").innerHTML = "Please enter your email";
}

function messageError() {
    $("message_error").innerHTML = "Please enter a message."
}

window.onload = function() {
    $("submit").onclick = validateEverything;
}