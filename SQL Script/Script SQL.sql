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

CREATE TABLE Caja (
    id_caja INT AUTO_INCREMENT,
    efectivoActual DECIMAL(20 , 2 ),
    PRIMARY KEY (id_caja)
);

CREATE TABLE Productos (
    id_producto INT AUTO_INCREMENT,
    cantidad INT,
    costo DECIMAL(7 , 2 ),
    nombre VARCHAR(50),
    PVUnitario DECIMAL(7 , 2 ),
    PVBulto DECIMAL(7 , 2 ),
    PRIMARY KEY (id_producto)
);

CREATE TABLE Clientes (
    id_cliente INT AUTO_INCREMENT,
    nombre VARCHAR(50),
    email VARCHAR(50),
    telefono VARCHAR(20),
    direccion VARCHAR(60),
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
    PRIMARY KEY (id_item),
    FOREIGN KEY (producto)
        REFERENCES Productos (id_producto),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);	

CREATE TABLE Facturas (
    id_factura INT AUTO_INCREMENT,
    fecha DATETIME,
    descripcion VARCHAR(1000),
    pedido INT,
    PRIMARY KEY (id_factura),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);

CREATE TABLE Operaciones (
    id_operacion INT AUTO_INCREMENT,
    operacion VARCHAR(30),
    PRIMARY KEY (id_operacion)
);

CREATE TABLE NotasDeCredito (
    id_NotaDeCredito INT AUTO_INCREMENT,
    factura INT,
    operacion INT,
    importe DECIMAL(7 , 5 ),
    PRIMARY KEY (id_NotaDeCredito),
    FOREIGN KEY (operacion)
        REFERENCES Operaciones (id_operacion),
    FOREIGN KEY (factura)
        REFERENCES Facturas (id_factura)
);


INSERT INTO Operaciones (operacion) VALUES ("Suma", "Resta");
