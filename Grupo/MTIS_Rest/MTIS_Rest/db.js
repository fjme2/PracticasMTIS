var mysql = require('mysql');

module.exports = function () {

    //bd 
    /*this.connect = function () {
        var result = mysql.createConnection({
            host: 'adriangosalvez.com',
            user: 'mtis_user',
            password: 'Mtis#314',
            database: 'mtis_'
        })

        return result
    }*/

    //bd local
    this.connect = function () {
        var result = mysql.createConnection({
            host: 'localhost',
            user: 'root',
            password: '',
            database: 'mtis_'
        })

        console.log('LOCAL');

        return result
    }


}