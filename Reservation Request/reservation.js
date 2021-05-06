$(document).ready(function() {
	
	let isValid = true;

	$("#submit").click(function() {

		$("#reservation_form").submit(function(evt) {
			let isValid = true;

			// Validate Date Entry
			
			let date = $("#arrival_date").val().trim();
			if (date == "") {
				$("#arrival_date").next().text("Please enter a valid date");
				isValid = false;
			}
			else {
				$("#arrival_date").next().text("");
			}

			// Validate Nights Entry 

			let nights = $("#nights").val().trim();

			if (isNaN(nights) || nights == "") {
				$("#nights").next().text("Please enter a valid number");
				isValid = false;
			}
			else {
				$("#nights").next().text("");
			}

			// Validate Name Entry

			let name = $("#name").val().trim();

			if(name == "") {
				$("#name").next().text("Please enter your name");
				isValid = false;
			}
			else {
				$("#name").next().text("");
			}

			// Validate Email Entry 

			let email = $("#email").val().trim();
			let emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;

			if (email == "") {
				$("#email").next().text("Please enter a email");
				isValid = false;
			}
			else if (!emailPattern.test(email) ) {
				$("#email").next().text("Please enter a valid email");
				isValid = false
			}
			else {
				$("#email").next().text("");
			}
			
			// Validate Phone Entry

			let phone = $("#phone").val().trim();

			if (phone == "") {
				$("#phone").next().text("Please enter a phone number");
				isValid = false;
			}
			else {
				$("#phone").next().text("");
			}

			if (isValid == false) {
				evt.preventDefault();
			}
		});
	});
}); // end ready