// API TOKEN
// pk_12f0507b574846369cc1793f31207998

//Declare Dependencies
const express = require('express');
const exphbs  = require('express-handlebars');
const request = require('request');
const path = require('path');
const bodyParser = require('body-parser');

// Instantiate Express
const app = express();

// Set Port Number
const PORT = process.env.PORT || 4000;

// Use Body Parser Middleware
app.use(bodyParser.urlencoded({extended: false}));

// Set View Engine
app.set('view engine', 'hbs');

// Set Configurations
app.engine('hbs', exphbs({
    layoutsDir: __dirname + '/views/layouts',
    extname: 'hbs'
}));

// Define static assets folder
app.use(express.static('public'));

// Create call_api function
function call_api(finishedAPI, name) {
    request('https://cloud.iexapis.com/stable/stock/' + name + '/quote?token=pk_12f0507b574846369cc1793f31207998', { json: true}, (err, res, body) => {
        if (err) {
            return console.log(err);
        }

        if (res.statusCode === 200) {
            finishedAPI(body);
        }
    });
};

// Set handlebar index GET route
app.get('/', (req, res) => {
    call_api(function (doneWithAPI)  {
        res.render('index' , {stock: doneWithAPI});
    }, "AMZN");
});

// Set handlebar index post route
app.post('/', (req, res) => {
    call_api(function (doneWithAPI) {
        res.render('index', {stock: doneWithAPI})
    }, req.body.stockName);
});

// Render about page 
app.get('/about', (req, res) => {
    res.render('about', {title: 'About Us'});
});

// Render contact page
app.get('/contact', (req, res) => {
    res.render('contact', {title: 'Contact Us'});
});

// Render file not found page 
app.get('*', (req, res) => {
    res.render('filenotfound', {title: 'File Not Found T_T'});
});

app.listen(PORT, () => {
    console.log(`App now running on port ${PORT}`);
});
