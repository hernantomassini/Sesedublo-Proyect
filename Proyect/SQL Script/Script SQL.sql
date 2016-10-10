/*Crear database*/
CREATE DATABASE IF NOT EXISTS Sesedublo;
USE Sesedublo;

#DROP TABLES:
DROP TABLE IF EXISTS NotasDeCredito;
DROP TABLE IF EXISTS Operaciones;
DROP TABLE IF EXISTS Facturas;
DROP TABLE IF EXISTS Items;
DROP TABLE IF EXISTS Pedidos;
DROP TABLE IF EXISTS Stock;
DROP TABLE IF EXISTS Clientes;
DROP TABLE IF EXISTS Productos;
DROP TABLE IF EXISTS Caja;

#DROP PROCEDURES:
DROP PROCEDURE IF EXISTS obtenerStock;
DROP PROCEDURE IF EXISTS agregarStock;
DROP PROCEDURE IF EXISTS modificarStock;
DROP PROCEDURE IF EXISTS borrarStock;
DROP PROCEDURE IF EXISTS obtenerProducto;
DROP PROCEDURE IF EXISTS agregarCliente;
DROP PROCEDURE IF EXISTS modificarCliente;
DROP PROCEDURE IF EXISTS cargarGrillaClientes;
DROP PROCEDURE IF EXISTS obtenerCliente;
DROP PROCEDURE IF EXISTS cargarGrillaFacturas;
DROP PROCEDURE IF EXISTS agregarEfectivo;
DROP PROCEDURE IF EXISTS restarEfectivo;
DROP PROCEDURE IF EXISTS obtenerMontoEnEfectivo;
DROP PROCEDURE IF EXISTS obtenerMontoEnProductos;
DROP PROCEDURE IF EXISTS cargarGrillaDeOperaciones;
DROP PROCEDURE IF EXISTS obtenerPedidos;
DROP PROCEDURE IF EXISTS borrarPedido;
DROP PROCEDURE IF EXISTS crearPedido;
DROP PROCEDURE IF EXISTS agregarItemAPedido;

CREATE TABLE Caja (
    id_caja INT AUTO_INCREMENT,
    efectivoActual DECIMAL(20 , 2 ),
    PRIMARY KEY (id_caja)
);

INSERT INTO Caja (efectivoActual) VALUES (0);

CREATE TABLE Productos (
    id_producto INT AUTO_INCREMENT,
    cantidad INT,
    cantidadXBulto INT,
    costo DECIMAL(7 , 2 ),
    nombre VARCHAR(50),
    PVUnitario DECIMAL(7 , 2 ),
    PVBulto DECIMAL(7 , 2 ),
    PRIMARY KEY (id_producto)
);

CREATE TABLE Clientes (
    id_cliente INT AUTO_INCREMENT,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    email VARCHAR(50),
    telefono VARCHAR(20),
    direccion VARCHAR(60),
    localidad VARCHAR(60),
    cuit VARCHAR(60),
    razonSocial VARCHAR(60),
    PRIMARY KEY (id_cliente)
);

CREATE TABLE Stock (
    id_stock INT AUTO_INCREMENT,
    producto INT,
    PRIMARY KEY (id_stock),
    FOREIGN KEY (producto)
        REFERENCES Productos (id_producto)
);

CREATE TABLE Pedidos (
    id_pedido INT AUTO_INCREMENT,
    comprador INT,
    pagadoHastaElMomento DECIMAL(7 , 2 ),
    precio DECIMAL(7 , 2 ),
    PRIMARY KEY (id_pedido),
    FOREIGN KEY (comprador)
        REFERENCES Clientes (id_cliente)
);

CREATE TABLE Items (
    id_item INT AUTO_INCREMENT,
    producto INT,
    pedido INT,
    cantidadProductos INT,
    PRIMARY KEY (id_item),
    FOREIGN KEY (producto)
        REFERENCES Productos (id_producto),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);	

CREATE TABLE Facturas (
    id_factura INT AUTO_INCREMENT,
    fecha DATETIME,
    descripcion VARCHAR(60),
    pedido INT,
    PRIMARY KEY (id_factura),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);

CREATE TABLE Operaciones (
    id_operacion INT AUTO_INCREMENT,
    operacion VARCHAR(200),
    descripcion VARCHAR(60),
    PRIMARY KEY (id_operacion)
);

CREATE TABLE NotasDeCredito (
    id_NotaDeCredito INT AUTO_INCREMENT,
    factura INT,
    importe DECIMAL(7 , 5 ),
    PRIMARY KEY (id_NotaDeCredito),
    FOREIGN KEY (factura)
        REFERENCES Facturas (id_factura)
);

#Store Procedures
DELIMITER //

CREATE PROCEDURE obtenerStock (IN _nombre VARCHAR(50)) 
BEGIN

	SELECT s.id_stock, p.cantidad, p.cantidadXBulto, p.nombre, p.costo, p.PVUnitario, p.PVBulto 
	FROM Stock s INNER JOIN Productos p 
	ON p.id_producto = s.producto
	WHERE ((p.nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""));

END //

CREATE PROCEDURE agregarStock (IN _cantidad INT, IN _cantidadXBulto INT, IN _costo DECIMAL(7,2), IN _nombre VARCHAR(50), IN _PVUnitario DECIMAL(7,2), IN _PVBulto DECIMAL(7,2)) 
BEGIN

	INSERT INTO Productos (cantidad, cantidadXBulto, costo, nombre, PVUnitario, PVBulto) VALUES (_cantidad, _cantidadXBulto, _costo, _nombre, _PVUnitario, _PVBulto);
    SET @_id_producto = LAST_INSERT_ID();
    INSERT INTO Stock (producto) VALUES (@_id_producto);
    
END //

CREATE PROCEDURE modificarStock (IN _id_stock INT, IN _cantidad INT, IN _cantidadXBulto INT, IN _costo DECIMAL(7,2), IN _nombre VARCHAR(50), IN _PVUnitario DECIMAL(7,2), IN _PVBulto DECIMAL(7,2)) 
BEGIN

SET @_id_producto = (SELECT producto FROM Stock WHERE id_stock = _id_stock);

	UPDATE Productos SET 
	cantidad = _cantidad,
    cantidadXBulto = _cantidadXBulto,
    costo = _costo,
    nombre = _nombre,
    PVUnitario = _PVUnitario,
    PVBulto = _PVBulto
    WHERE id_producto = @_id_producto;

END //

CREATE PROCEDURE borrarStock (IN _id_stock INT) 
BEGIN

SET @_id_producto = (SELECT producto FROM Stock WHERE id_stock = _id_stock);

	DELETE FROM Stock WHERE id_stock = _id_stock;
	DELETE FROM Productos WHERE id_producto = @_id_producto;

END //

CREATE PROCEDURE obtenerProducto (IN _id_stock INT) 
BEGIN

SET @_id_producto = (SELECT producto FROM Stock WHERE id_stock = _id_stock);

	SELECT 
    cantidad, cantidadXBulto, nombre, costo, PVUnitario, PVBulto
FROM
    Productos
WHERE
    id_producto = @_id_producto;
    
END //

CREATE PROCEDURE cargarGrillaClientes (IN _nombre VARCHAR(255), _apellido VARCHAR(50), _direccion VARCHAR(255))
BEGIN

	SELECT c.id_cliente, c.nombre AS Nombre, c.apellido AS Apellido, c.email AS Mail, c.telefono AS Teléfono, c.direccion AS Dirección, c.localidad AS Localidad, c.cuit as CUIT, c.razonSocial AS Razon_Social FROM Clientes c
	WHERE ((c.nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
	AND ((c.apellido LIKE CONCAT("%", _apellido, "%") COLLATE utf8_general_ci ) OR (_apellido IS NULL OR _apellido = ""))
	AND ((c.direccion LIKE CONCAT("%", _direccion, "%") COLLATE utf8_general_ci) OR (_direccion IS NULL OR _direccion = ""));
END //

CREATE PROCEDURE agregarCliente (IN _nombre VARCHAR(255), _apellido VARCHAR(255), _mail VARCHAR(255),
							   _direccion VARCHAR(50), _telefono VARCHAR(60), _localidad VARCHAR(60),
                               _cuit VARCHAR(60), _razonSocial VARCHAR(60))
BEGIN

    INSERT INTO Clientes (nombre, apellido, email, telefono, direccion, localidad, cuit, razonSocial) VALUES (_nombre, _apellido, _mail, _telefono, _direccion, _localidad, _cuit, _razonSocial);
    
END //

CREATE PROCEDURE modificarCliente (IN _id_cliente INT, _nombre VARCHAR(255), _apellido VARCHAR(255), _mail VARCHAR(255),
										_direccion VARCHAR(50), _telefono VARCHAR(60), _localidad VARCHAR(60),
                               _cuit VARCHAR(60), _razonSocial VARCHAR(60))
BEGIN
    UPDATE Clientes SET nombre = _nombre, email = _mail, telefono = _telefono, apellido = _apellido, direccion = _direccion, localidad = _localidad, cuit = _cuit, razonSocial = _razonSocial WHERE id_cliente = _id_cliente ;
END //

CREATE PROCEDURE obtenerCliente (IN _id_cliente INT) 
BEGIN

	SELECT nombre, apellido, email, telefono, direccion, localidad, cuit, razonSocial FROM Clientes WHERE id_cliente = _id_cliente;
END //

CREATE PROCEDURE cargarGrillaFacturas (IN _nombre VARCHAR(255), _apellido VARCHAR(255), _descripcion VARCHAR(50), _direccion VARCHAR(255))
BEGIN
	SELECT f.id_factura, c.id_cliente, c.nombre AS Nombre, c.apellido AS Apellido, c.direccion AS Dirección, p.precio AS Precio FROM Facturas f
    INNER JOIN Pedidos p ON p.id_pedido = f.pedido
    INNER JOIN Clientes c ON c.id_cliente = p.comprador
	WHERE ((f.descripcion LIKE CONCAT("%", _descripcion, "%") COLLATE utf8_general_ci ) OR (_descripcion IS NULL OR _descripcion = ""))
	AND ((c.nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
	AND ((c.apellido LIKE CONCAT("%", _apellido, "%") COLLATE utf8_general_ci ) OR (_apellido IS NULL OR _apellido = ""))
	AND ((c.direccion LIKE CONCAT("%", _direccion, "%") COLLATE utf8_general_ci) OR (_direccion IS NULL OR _direccion = ""));
END //

CREATE PROCEDURE agregarEfectivo (IN _montoASumar INT, _descripcion VARCHAR(60)) 
BEGIN

SET @_efectivo = (SELECT efectivoActual FROM Caja WHERE id_caja = 1);

    UPDATE Caja SET efectivoActual = (@_efectivo + _montoASumar) WHERE id_caja=1;
    INSERT INTO Operaciones (operacion, descripcion) VALUES ("Efectivo entrante", _descripcion);

END //

CREATE PROCEDURE restarEfectivo (IN _montoARestar INT, _descripcion VARCHAR(60)) 
BEGIN

	SET @_efectivo = (SELECT efectivoActual FROM Caja WHERE id_caja = 1);

    UPDATE Caja SET efectivoActual = (@_efectivo - _montoARestar) WHERE id_caja=1;
    INSERT INTO Operaciones (operacion, descripcion) VALUES ("Efectivo saliente", _descripcion);
    
END //

CREATE PROCEDURE obtenerMontoEnEfectivo () 
BEGIN

	SELECT efectivoActual FROM Caja WHERE id_caja = 1;

END //

CREATE PROCEDURE obtenerMontoEnProductos () 
BEGIN

	SELECT SUM(p.costo * p.) FROM Stock s INNER JOIN Productos p
	ON p.id_producto = s.producto;

END //

CREATE PROCEDURE cargarGrillaDeOperaciones (IN  _operacion VARCHAR(255), _descripcion VARCHAR(50))
BEGIN
	SELECT operacion AS Operación, descripcion AS Descripción FROM Operaciones
	WHERE ((descripcion LIKE CONCAT("%", _descripcion, "%") COLLATE utf8_general_ci ) OR (_descripcion IS NULL OR _descripcion = ""))
	AND ((operacion LIKE CONCAT("%", _operacion, "%") COLLATE utf8_general_ci ) OR (_operacion IS NULL OR _operacion = ""));
END //

CREATE PROCEDURE obtenerPedidos () 
BEGIN
        SELECT p.id_pedido, c.nombre, c.apellido, p.pagadoHastaElMomento, p.precio, group_concat(pr.nombre)  FROM Pedidos p 
        LEFT OUTER JOIN Facturas f ON p.id_pedido = f.pedido
        INNER JOIN Clientes c ON p.comprador = c.id_cliente
        INNER JOIN Items i ON p.id_pedido = i.pedido
        INNER JOIN Productos pr ON i.producto = pr.id_producto
		WHERE f.pedido IS NULL;
END //

CREATE PROCEDURE borrarPedido (IN _id_pedido INT)
BEGIN

	DELETE FROM Pedidos WHERE id_pedido = _id_pedido;

END //

CREATE PROCEDURE crearPedido (IN _id_comprador INT, IN _pagadoHastaElMomento DECIMAL(7,2), IN _precio DECIMAL(7,2))
BEGIN

	SET @_nombreComprador = (SELECT CONCAT(nombre, ", " ,apellido) FROM Clientes WHERE id_cliente = _id_comprador);
    SET @_descripcion = CONCAT("El cliente ", @_nombreComprador, " realizó un pedido y dejo pago ", _pagadoHastaElMomento, "$.");
	CALL agregarEfectivo(_pagadoHastaElMomento, @_descripcion);

	INSERT INTO Pedidos (comprador, pagadoHastaElMomento, precio) VALUES (_id_comprador, _pagadoHastaElMomento, _precio);
	SELECT LAST_INSERT_ID();
END //

CREATE PROCEDURE agregarItemAPedido (IN _id_pedido INT, IN _id_producto INT, IN _cantidad INT)
BEGIN

SET @_nuevaCantidad = (SELECT cantidad WHERE id_producto = _id_producto) - _cantidad;

	UPDATE Productos SET cantidad = @_nuevaCantidad WHERE id_producto = _id_producto;
	INSERT INTO Items (producto, pedido, cantidadProductos) VALUES (_id_producto, _id_pedido, _cantidad);

    
END //

DELIMITER ;
