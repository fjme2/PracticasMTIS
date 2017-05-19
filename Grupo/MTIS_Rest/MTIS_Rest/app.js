//paquetes
var express = require('express');
var bodyParser = require('body-parser');

require('./db')();

//utilizando paquetes
var app = express();
app.use(bodyParser());

//enlazamos archivos
var chordi = require('./routes/Chordi')
//var db = require('./db')
app.use('/chordi', chordi)

//PUERTO
app.listen(process.env.PORT || 5000, function () {
    console.log('Express en el puerto 5000');
})
