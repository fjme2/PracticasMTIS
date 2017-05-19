var express = require('express');
var chordi = express.Router();
module.exports = chordi;

chordi.post('/presupuesto/:idCliente/:idEvento', function (req, res) {

    var idCliente = req.params.idCliente;
    var idEvento = req.params.idEvento;


    connect().query('SELECT SUM(precio) AS Precio FROM material WHERE id IN (SELECT idMaterial FROM material_x_evento WHERE idEvento =' + idEvento + ')'
        + ' UNION SELECT SUM(precio) FROM vehiculo WHERE id IN (SELECT idVehiculo FROM vehiculo_x_evento WHERE idEvento =' + idEvento + ')'
        + ' UNION SELECT SUM(cache) FROM trabajador WHERE id IN (SELECT idTrabajador FROM trabajador_x_evento WHERE idEvento =' + idEvento + ')'
        + ' UNION SELECT SUM(precio) FROM recintos  WHERE id IN (SELECT idRecinto FROM eventorecinto WHERE idEvento =' + idEvento + ');', function (err, rows, fields) {
        if (err) {
            res.sendStatus(404).send('No conectado')
        }else if (rows.length == 0) {
            res.sendStatus(500).send('No existe el cliente')
        } else {
            var material = rows[0].Precio;
            var vehiculo = rows[1].Precio;
            var trabajador = rows[2].Precio;
            var recinto = rows[3].Precio;

            console.log('Material=' + material + ', Vehiculo=' + vehiculo + ', Trabajador=' + trabajador + ', Recinto=' + recinto)
            var precio = material + vehiculo + trabajador + recinto;
            var pvp = precio + 200;

            var query = connect().query('INSERT INTO presupuesto (id, idCliente, idEvento, precio, pvp, cdate) VALUES (NULL,\'' + idCliente + '\',\'' + idEvento + '\',\'' + precio + '\', \'' + pvp + '\', NOW());', function (err, result) {
                if (err) {
                    res.sendStatus(404).send('Error al insertar')
                    console.log(err)
                } else {
                    console.log('Inserta')
                    res.sendStatus(200).send(pvp)
                }
            });
            
        }
    })

    //res.status(200).send(id)
});

chordi.put('/presupuesto/:idCliente/:idEvento', function (req, res) {
    var idEvento = req.params.idEvento;
    var respuesta = req.body.respuesta;
    if (respuesta == true) {
        connect().query('UPDATE presupuesto SET aceptado=\'' + 1 + '\', pagado=\'' + 0 + '\', anulado=\'' + 0 + '\' WHERE idEvento=' + idEvento + '', function (err, rows, fields) {
            if (err || rows.affectedRows == 0) {
                res.sendStatus(500).send(err);
            } else {
                res.sendStatus(200).send('Actualizado aceptado');
            }
        });
    } else {
        connect().query('UPDATE presupuesto SET aceptado=\'' + 0 + '\', pagado=\'' + 0 + '\', anulado=\'' + 1 + '\' WHERE idEvento=' + idEvento + '', function (err, rows, fields) {
            if (err || rows.affectedRows == 0) {
                res.sendStatus(500).send('Error declinado');
            } else {
                res.sendStatus(200).send('Actualizado declinado');
            }
        });
    }

});

chordi.delete('/presupuesto/:idCliente/:idEvento', function (req, res) {
    var idEvento = req.params.idEvento;
    connect().query('delete from trabajador_x_evento where trabajador_x_evento.idEvento = \'' + idEvento + '\';', function (err, rows, fields) {
        if (err || rows.affectedRows == 0) {
            console.log(idEvento)
            res.sendStatus(500).send(err);
        } else {
            res.sendStatus(200).send('Borrado con exito');
        }
    });
});

/*trabajador_x_evento, eventorecinto*/