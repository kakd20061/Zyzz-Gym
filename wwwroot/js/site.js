// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function sendMail() {
    if (isValid() == true) {
        modalShow();
        var params = {
            name: document.getElementById("name").value,
            email: document.getElementById("email").value,
            message: document.getElementById("message").value,
        };
        const serviceID = "service_5ccpyi8";
        const templateID = "template_u67gfjm";

        emailjs.send(serviceID, templateID, params).then(res => {
            document.getElementById("name").value = "";
            document.getElementById("email").value = "";
            document.getElementById("message").value = "";
            console.log(res);
        }).catch(err => console.log(err));
    }
    else {
        modalShow();
    }
}

function modalShow() {
    $("#modal").modal("show");
}

function isValid() {
    let errorCounter = 0;
    const name = document.getElementById("name").value;
    const email = document.getElementById("email").value;
    const message = document.getElementById("message").value;
    const errorAlertText = document.getElementById("error");
    errorAlertText.innerHTML = "";
    if (/^[a-zA-Z]{3,}$/.test(name) == false) {
        errorCounter += 1;
        errorAlertText.innerHTML += "Enter the correct name! <br/>";
    }

    if (/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/.test(email) == false) {
        errorCounter += 1;
        errorAlertText.innerHTML += "Enter the correct email! <br/>";
    }

    if (message == null || message.trim() === '') {
        errorCounter += 1;
        errorAlertText.innerHTML += "Message is not suitable! <br/>";
    }

    if (errorCounter == 0) {
        document.getElementById("modalLabel").innerText = "Success";
        document.getElementById("modalButton").classList.remove("btn-danger");
        document.getElementById("modalButton").classList.add("btn-success");
        document.getElementById("modalButton").innerText = "Ok";
        errorAlertText.innerHTML = "Your message has been sent to us! <br/> We will reply as soon as possible";
        return true;
    }
    else {
        document.getElementById("modalLabel").innerText = "Error";
        document.getElementById("modalButton").classList.remove("btn-success");
        document.getElementById("modalButton").classList.add("btn-danger");
        document.getElementById("modalButton").innerText = "Cancel";
        return error;
    }
}

function validatePriceAdd() {
    const nameError = document.getElementById("priceNameError");
    const nameForm = document.getElementById("priceName").value;
    const priceError = document.getElementById("priceError");
    const priceForm = document.getElementById("pricePrice").value;
    const descriptionError = document.getElementById("priceDescriptionError");
    const descriptionForm = document.getElementById("priceDescription").value;
    nameError.innerText = "";
    priceError.innerText = "";
    descriptionError.innerText = "";
    let errorCount = 0;
    if (nameForm == null || nameForm.trim() === '') {
        errorCount += 1;
        nameError.innerText = "Name can't be empty!";
    }
    if (priceForm == null || priceForm.trim() === '') {
        errorCount += 1;
        priceError.innerText = "Price can't be empty!";
    }
    //}else if (isNaN(priceForm)) {
    //    errorCount += 1;
    //    priceError.innerText = "Price must be a number!";
    //}
    if (descriptionForm == null || descriptionForm.trim() === '') {
        errorCount += 1;
        descriptionError.innerText = "Description can't be empty!";
    }
    if (errorCount > 0) {
        return false;
    }
}

function validatePriceEdit(id) {


    const nameForm = document.getElementById(`priceNameEdit-${id}`).value;

    const priceForm = document.getElementById(`pricePriceEdit-${id}`).value;

    const descriptionForm = document.getElementById(`priceDescriptionEdit-${id}`).value;

    const errorAlertText = document.getElementById("errorText");
    errorAlertText.innerText = "";


    let errorCount = 0;

    if (nameForm == null || nameForm.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Name can't be empty!<br/>";
    }
    if (priceForm == null || priceForm.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Price can't be empty!<br/>";
    }
    if (descriptionForm == null || descriptionForm.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Description can't be empty!<br/>";
    }
    if (errorCount > 0) {
        modalShow2();
        return false;
    }
}

function modalShow2() {
    $("#modal2").modal("show");
}

function validateAnnouncementsAdd() {
    const titleError = document.getElementById("titleError");
    const title = document.getElementById("title").value;
    const urlError = document.getElementById("urlError");
    const url = document.getElementById("url").value;
    const descriptionError = document.getElementById("descriptionError");
    const descriptionForm = document.getElementById("desc").value;
    titleError.innerText = "";
    urlError.innerText = "";
    descriptionError.innerText = "";
    let errorCount = 0;
    if (title == null || title.trim() === '') {
        errorCount += 1;
        titleError.innerText = "Title can't be empty!";
    }
    if (url == null || url.trim() === '') {
        errorCount += 1;
        urlError.innerText = "Url can't be empty!";
    }
    if (descriptionForm == null || descriptionForm.trim() === '') {
        errorCount += 1;
        descriptionError.innerText = "Description can't be empty!";
    }
    if (errorCount > 0) {
        return false;
    }
}

function validateAnnouncementsEdit(id) {


    const title = document.getElementById(`titleEdit-${id}`).value;

    const url = document.getElementById(`urlEdit-${id}`).value;

    const descriptionForm = document.getElementById(`descEdit-${id}`).value;

    const errorAlertText = document.getElementById("errorMessage");
    errorAlertText.innerText = "";


    let errorCount = 0;

    if (title == null || title.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Title can't be empty!<br/>";
    }
    if (url == null || url.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Url can't be empty!<br/>";
    }
    if (descriptionForm == null || descriptionForm.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Description can't be empty!<br/>";
    }
    if (errorCount > 0) {
        modalShow3();
        return false;
    }
}


function modalShow3() {
    $("#modal3").modal("show");
}

function validateExerciseAdd() {

    const nameError = document.getElementById("NameInputError");
    const nameInput = document.getElementById("nameInput").value;
    nameError.innerText = "";

    let errorCount = 0;
    if (nameInput == null || nameInput.trim() === '') {
        errorCount += 1;
        nameError.innerText = "Name can't be empty!";
    }

    if (errorCount > 0) {
        return false;
    }
}

function validateExerciseEdit(id) {


    const name = document.getElementById(`exerciseNameEdit-${id}`).value;



    const errorAlertText = document.getElementById("errorMessageExercise");
    errorAlertText.innerText = "";


    let errorCount = 0;

    if (name == null || name.trim() === '') {
        errorCount += 1;
        errorAlertText.innerHTML += "Name can't be empty!<br/>";
    }

    if (errorCount > 0) {
        modalShow4();
        return false;
    }
}

function modalShow4() {
    $("#modal4").modal("show");
}

function validateAchievementsAdd() {

    const repsError = document.getElementById("repsError");
    const weightError = document.getElementById("weightError");
    const repsInput = document.getElementById("repsInput").value;
    const weightInput = document.getElementById("weightInput").value;
    repsError.innerText = "";
    weightError.innerText = "";

    let errorCount = 0;
    if (repsInput == null || repsInput.trim() === '') {
        errorCount += 1;
        repsError.innerText = "Reps can't be empty!";
    }
    if (weightInput == null || weightInput.trim() === '') {
        errorCount += 1;
        weightError.innerText = "Weight can't be empty!";
    }

    if (errorCount > 0) {
        return false;
    }
}

function validateRequestAdd() {

    const name = document.getElementById("nameRequest").value;
    const nameError = document.getElementById("nameRequestError");

    nameError.innerText = "";

    let errorCount = 0;
    if (name == null || name.trim() === '') {
        errorCount += 1;
        nameError.innerText = "Name can't be empty!";
    }


    if (errorCount > 0) {
        return false;
    }
}