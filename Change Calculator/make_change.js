/*
		In this exercise, you'll develop an application that
		tells how many quarters, dimes, nickels, and pennies are
		needed to make change for any amount of change from 0 
		through 99 cents.
		
		One way to get the results is to use the divide and
		modulus operators along with the parseInt() method for 
		truncating the results so they are whole numbers.
		
		1.	Open the HTML and JavaScript files in this folder:
			exercises_extra\ch04\change_maker\
			
			Then, run the application to see the user interface shown 
			above, although that interface won't do anything until you 
			develop the JavaScript for it.

		2.	In the JavaScript file, note that the $ function has already 
			been coded.

		3.	Code an event handler named processEntry() that gets the user's 
			entry and checks to make sure that it is a number between 0 and 
			99. If it isn't, display an alert dialog box for the error. If it
			is valid, call a function named makeChange() and pass it the 
			user's entry.

		4.	Code the makeChange() function, which should have one parameter 
			that accepts the user's entry. This function shouldn't return 
			anything, but it should display the results in the text boxes for 
			Quarters, Dimes, Nickels, and Pennies.

		5.	Code an onload event handler that attaches the processEntry() 
			event handler to the click event of the Make Change button. Then, 
			test this application.
 */


const MINAMT = 1;
const MAXAMT = 100;
const ERRMSG = "Entry must be > 0 and <= 100";

let $ = function(id) {
    return document.getElementById(id);
};

let processEntry = function() {
	let entry = $("cents").value;
	let cents = parseInt(entry);
	
	if (isNaN(entry) || (entry < MINAMT) || (entry > MAXAMT)) {
		alert(ERRMSG);
		$("cents").value = "";
	}

	else {
		makeChange(cents);
	}
}

let makeChange = function(cents) {
	let numQuarters = 0;
	let numDimes   = 0;
	let numNickels = 0;
	let numPennies = 0;
	let changeLeft = 0;

	numQuarters = Math.floor(cents / 25);
	changeLeft = Math.floor(cents % 25);

	numDimes = Math.floor(changeLeft / 10);
	changeLeft =  Math.floor(changeLeft % 10);

	numNickels = Math.floor(changeLeft / 5);
	numPennies = Math.floor(changeLeft % 5);
	
	$("quarters").value = numQuarters;
	$("dimes").value = numDimes;
	$("nickels").value = numNickels;
	$("pennies").value = numPennies;

}

window.onload = function() {
	$("calculate").onclick = processEntry;
	$("cents").focus();
}

