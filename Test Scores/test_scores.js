let names = ["Ben", "Joel", "Judy", "Anne"];
let scores = [88, 98, 77, 88];

let $ = function (id) { 
	return document.getElementById(id); 
};

/* 
	Write the display Results function(). It should derive the average score
	and the highest score from the arrays then display them in the div element.
	Add nodes to the DOM (h2 and p).
*/
function displayResults() {
	let total = 0;
	for (i = 0; i < scores.length; ++i) {
		total += scores[i];
	}
	
	let avg = total / scores.length;
	let highscore = Math.max.apply(null,scores);
	let a = scores.indexOf(highscore);
	let person = names[a];

	$("results").innerHTML = "<h2>Results</h2>" + "Average score = " + avg + "<br>" + "High score = " + person + " with a score of " + highscore;
};

/* 
	Write the displayScores() function. It should get the names and scores 
	from the arrays and display them as rows in the HTML.

*/

function displayScores() {
	let table = "<h2>Scores</h2> <td>Name</td> <td>Score</td>";
	for (i = 0; i < names.length; i++) {
		table += "<tr>";
		table += "<td>" + names[i] + "</td>";
		table += "<td>" + scores[i] + "</td>";
	}

	$("scores_table").innerHTML = table;
}
/* 
	Write the addScore() function. It should add a name 
	and score to the two arrays. 
*/

function addScore() {
	let name = $("name").value;
	let score = parseInt( $("score").value);
	
	if (name == "" || isNaN(score) || score < 0 || score > 100) {
    	alert("You must enter a name and a valid score");
	}
	else {
	names[names.length] = name;
	scores[scores.length] = score;

	$("name").value = "";
	$("score").value = "";
	$("name").focus();
	}
}


window.onload = function() {
	$("add").onclick = addScore;
	$("display_results").onclick = displayResults;
	$("display_scores").onclick = displayScores;
};
