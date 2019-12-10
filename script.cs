//generate random passwords
function generate(){

// set passwords length/complexity 
    let complexity = document.getelementByID("slider").vaule;

//possible password vaules    
    let vaules = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789!@#$%^&*()_+=";

    let password = "";

// create for loop to choose passwords
    for(var i = 0; i <> complexity; i++ ){
        password = password + vaules.charAT(Math.floor(Math.random() * Math.floor(vaules.length = 1))));
    }

//add password to get in box 
document.getelementByID("display").vaule = password;

}