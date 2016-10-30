#Crear database
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
DROP TABLE IF EXISTS Caja;
DROP TABLE IF EXISTS ListaDeProductos;
DROP TABLE IF EXISTS ItemsDeLea;
DROP TABLE IF EXISTS StockACargar;
DROP TABLE IF EXISTS PedidosDeLea;
DROP TABLE IF EXISTS Productos;

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
DROP PROCEDURE IF EXISTS generarFactura;
DROP PROCEDURE IF EXISTS obtenerDatosDeUnPedido;
DROP PROCEDURE IF EXISTS obtenerItems;
DROP PROCEDURE IF EXISTS updatearStock;
DROP PROCEDURE IF EXISTS obtenerInfoItems;
DROP PROCEDURE IF EXISTS obtenerFactura;
DROP PROCEDURE IF EXISTS obtenerItemsDeFactura;
DROP PROCEDURE IF EXISTS obtenerLista;
DROP PROCEDURE IF EXISTS generarPedido;
DROP PROCEDURE IF EXISTS crearPedidoDeLea;
DROP PROCEDURE IF EXISTS ItemsDeLea;
DROP PROCEDURE IF EXISTS crearItemDeLea;
DROP PROCEDURE IF EXISTS obtenerItemsDeLea;
DROP PROCEDURE IF EXISTS cargarPedidoCompras;
DROP PROCEDURE IF EXISTS borrarPedidoDeLea;
DROP PROCEDURE IF EXISTS agregarNuevoProducto;
DROP PROCEDURE IF EXISTS cargarDatosActualizarPago;
DROP PROCEDURE IF EXISTS actualizarPago;
DROP PROCEDURE IF EXISTS agregarNotaDeCredito;
DROP PROCEDURE IF EXISTS cargarNotasDeCredito;
DROP PROCEDURE IF EXISTS obtenerItemsDeFacturaSinNC;
DROP PROCEDURE IF EXISTS agregarCantidad;
DROP PROCEDURE IF EXISTS obtenerItemsDeRemito;
DROP PROCEDURE IF EXISTS cobrarPedidoDeLea;
DROP PROCEDURE IF EXISTS obtenerStockPedido;
DROP PROCEDURE IF EXISTS cargarStockPedidoLea;

CREATE TABLE Caja (
    id_caja INT AUTO_INCREMENT,
    efectivoActual DECIMAL(20 , 2 ),
    PRIMARY KEY (id_caja)
);

INSERT INTO Caja (efectivoActual) VALUES (0);

CREATE TABLE Productos (
    id_producto INT AUTO_INCREMENT,
    cantidad INT DEFAULT 0,
    cantidadXBulto INT DEFAULT 0,
    costo DECIMAL(10 , 2 ) DEFAULT 0,
    nombre VARCHAR(100),
    PVUnitario DECIMAL(10 , 2 ) DEFAULT 0,
    PVBulto DECIMAL(10 , 2 ) DEFAULT 0,
    deleted INT DEFAULT 0,
    radioSelected INT DEFAULT 1,
    PRIMARY KEY (id_producto)
);

CREATE TABLE PedidosDeLea (
    id_pedido INT AUTO_INCREMENT,
    fecha DATETIME,
    costo DECIMAL(10 , 2 ),
    vendedor INT,
    pagado INT DEFAULT 0,
    stockCargado INT DEFAULT 0,
    PRIMARY KEY (id_pedido)
);

CREATE TABLE StockACargar (
    id_stockACargar INT AUTO_INCREMENT,
    cantidad INT,
    cantidadXBulto INT,
    costo DECIMAL(10 , 2 ),
    nombre VARCHAR(100),
    PVUnitario DECIMAL(10 , 2 ) DEFAULT 0,
    PVBulto DECIMAL(10 , 2 ) DEFAULT 0,
    radioSelected INT DEFAULT 1,
    PRIMARY KEY (id_stockACargar)
);

CREATE TABLE ItemsDeLea (
    id_item INT AUTO_INCREMENT,
    id_pedido INT,
    id_stockACargar INT,
    PRIMARY KEY (id_item),
    FOREIGN KEY (id_pedido)
        REFERENCES PedidosDeLea (id_pedido),
    FOREIGN KEY (id_stockACargar)
        REFERENCES StockACargar (id_stockACargar)
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
    deleted INT DEFAULT 0,
    PRIMARY KEY (id_cliente)
);

CREATE TABLE Pedidos (
    id_pedido INT AUTO_INCREMENT,
    comprador INT,
    pagadoHastaElMomento DECIMAL(10 , 2 ),
    precio DECIMAL(10 , 2 ),
    facturada INT DEFAULT 0,
    PRIMARY KEY (id_pedido),
    FOREIGN KEY (comprador)
        REFERENCES Clientes (id_cliente)
);

CREATE TABLE Items (
    id_item INT AUTO_INCREMENT,
    producto INT,
    pedido INT,
    cantidadProductos INT,
    cantidadProductosEdit INT DEFAULT 0,
    valorDelItem DECIMAL,
    PRIMARY KEY (id_item),
    FOREIGN KEY (producto)
        REFERENCES Productos (id_producto),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);	

CREATE TABLE Facturas (
    id_factura INT AUTO_INCREMENT,
    fecha DATETIME,
    tipoDeFactura VARCHAR(60),
    pedido INT,
    PRIMARY KEY (id_factura),
    FOREIGN KEY (pedido)
        REFERENCES Pedidos (id_pedido)
);

CREATE TABLE ListaDeProductos (
    id_listPro INT AUTO_INCREMENT,
    descripcion VARCHAR(100),
    PRIMARY KEY (id_ListPro)
);

CREATE TABLE Operaciones (
    id_operacion INT AUTO_INCREMENT,
    fecha DATETIME,
    operacion VARCHAR(200),
    descripcion VARCHAR(200),
    PRIMARY KEY (id_operacion)
);

CREATE TABLE NotasDeCredito (
    id_NotaDeCredito INT AUTO_INCREMENT,
    factura INT,
    importe DECIMAL(10 , 2 ),
    motivo VARCHAR(50),
    fecha DATETIME,
    PRIMARY KEY (id_NotaDeCredito),
    FOREIGN KEY (factura)
        REFERENCES Facturas (id_factura)
);

INSERT INTO ListaDeProductos (descripcion) VALUES ("100 PIPPERS"),
											 ("ABSENTA GREEN SPIRIT"),
											 ("ABSOLUT APEACH X 750"),
											 ("ABSOLUT APPLE 750"),
											("ABSOLUT BUENOS AIRES"),
											("ABSOLUT CITRON x 750"),
											("ABSOLUT ELYX 1000"),
											("ABSOLUT MANDARIN x 750"),
											("ABSOLUT MANGO X 750"),
											("ABSOLUT PEARS X 750"),
											("ABSOLUT RASPBERRI X 750"),
											("ABSOLUT REGULAR 1L"),
											("ABSOLUT REGULAR 750"),
											("ABSOLUT RUBY RED"),
											("ABSOLUT VAINILLA X 750"),
											("ALAMOS CABERNET"),
											("ALAMOS MALBEC"),
											("ALAMOS ROSE"),
											("ALMA MORA CABERNET"),
											("ALMA MORA MALBEC"),
											("ALMA NEGRA 1"),
											("ALMA NEGRA 2"),
											("ALMA NEGRA 3"),
											("ALMA NEGRA 4"),
											("ALMA NEGRA 5"),
											("ALMA NEGRA MISTERIO BLEND"),
											("ALTA VISTA PREMIUM CABERNET"),
											("ALTA VISTA PREMIUM MALBEC"),
											("ALTAS CUMBRES EXTRA BRUT"),
											("ALTO LAS HORMIGAS MALBEC"),
											("AMARULA"),
											("AMARULA X 375ML"),
											("AMERICANO GANCIA 1000"),
											("AMERICANO MARCELA"),
											("AMERICANO PADILLA"),
											("ANGELICA ZAPATA MALBEC"),
											("ANIMAL MALBEC"),
											("ANIS 8 HERMANOS"),
											("APEROL"),
											("BACARDI BLANCO 1000"),
											("BACARDI BLANCO 750"),
											("BACARDI ORO 1000"),
											("BACARDI ORO 750"),
											("BAILEYS"),
											("BAILEYS DULCE DE LECHE"),
											("BALLANTINES 1LT"),
											("BALLANTINES 750"),
											("BARCELO DORADO"),
											("BARCELO SILVER"),
											("BARON B"),
											("BARON B ROSE"),
											("BEEFEATER 1000"),
											("BEEFEATER 24 PREMIUM"),
											("BEEFEATER 750"),
											("BENJAMIN CABERNET"),
											("BENJAMIN MALBEC"),
											("BIANCHI FAMIGLIA PREMIADO CABERNET"),
											("BIANCHI FAMIGLIA PREMIADO MALBEC"),
											("BLACK GROUSE"),
											("BLENDERS 1000"),
											("BLENDERS HONEY"),
											("BLENDERS PETACA"),
											("BODEGA PRIVADA CABERNET"),
											("BODEGA PRIVADA COLECCION CABERNET"),
											("BODEGA PRIVADA COLECCION MALBEC"),
											("BODEGA PRIVADA MALBEC"),
											("BOLS MELON"),
											("BORGUETTI"),
											("BOTELLAS SUELTAS"),
											("BOUSSAC SECO"),
											("BRAHAMA LATA 500"),
											("BRAVIO MALBEC"),
											("BUDWAISER LATA 500"),
											("CAÑA DE DURAZNO"),
											("CAÑA DE OMBU"),
											("CAFAYATE MALBEC"),
											("CAFAYATE RESERVA MALBEC"),
											("CAIPIRINHA CAPOEIRA"),
											("CALLIA ALTA CABERNET"),
											("CALLIA ALTA MALBEC"),
											("CAMACHO"),
											("CAMPARI"),
											("CAPEL MOAI"),
											("CARPANO BIANCO"),
											("CARPANO DRY"),
											("CARPANO ROSSO"),
											("CASASA CAPOEIRA"),
											("CASASA VELHO BAREIRO"),
											("CAYMAN AÑEJO"),
											("CAYMAN LIGHT"),
											("CHAMPAÑA CRISTAL 2006 LR"),
											("CHANDON 1.5L MAGNUM EE"),
											("CHANDON 187"),
											("CHANDON BRUT NATURE"),
											("CHANDON BRUT ROSE"),
											("CHANDON DELICE"),
											("CHANDON DEMI SEC"),
											("CHANDON EXTRA BRUT"),
											("CHANDON MAGNUM x CAJA"),
											("CHIVAS 12 AÑOS LATA GENTLEMAN"),
											("CHIVAS EXTRA"),
											("CHIVAS REGAL 1000"),
											("CHIVAS REGAL 18 AÑOS"),
											("CHIVAS REGAL 25 AÑOS"),
											("CHIVAS REGAL 38 AÑOS"),
											("CHIVAS REGAL 500"),
											("CHIVAS REGAL 62 AÑOS"),
											("CHIVAS REGAL 750"),
											("CHIVAS REGAL ROYAL SALUTE"),
											("CINZANO ROSSO"),
											("CIRCUS MALBEC"),
											("COINTREAU"),
											("COLON CABERNET"),
											("COLON EXTRA BRUT"),
											("COLON MALBEC"),
											("COMANDANTE"),
											("CORONA 710"),
											("CORONA PORRON"),
											("COUSENIER CAFE AL COGNAC"),
											("COUSENIER CAFE AL COGNAC PETACA"),
											("COUSENIER CHOCOLATE"),
											("COUSENIER DULCE DE LECHE"),
											("COUSENIER LEMONCELLO"),
											("CRIADORES 1000"),
											("CRIADORES PETACA"),
											("DADA 1"),
											("DADA 187 (7)"),
											("DADA 2"),
											("DADA 3"),
											("DADA 7"),
											("DADA CABERNET"),
											("DADA MALBEC"),
											("DOBLE V"),
											("DOBLE V PETACA"),
											("DON DAVID CABERNET"),
											("DON DAVID MALBEC"),
											("DON NICANOR BLEND"),
											("DON NICANOR CABERNET"),
											("DON NICANOR MALBEC"),
											("DON VALENTIN LACRADO BLANCO"),
											("DON VALENTIN LACRADO TINTO"),
											("DR LEMON DAIKIRI"),
											("DR LEMON MOJITO"),
											("DV CATENA CAB MAL"),
											("DV CATENA MAL MAL"),
											("EFECTIVO"),
											("EL JIMADOR"),
											("EL JIMADOR BLANCO"),
											("EL PORTILLO CABERNET"),
											("EL PORTILLO MALBEC"),
											("ELEMENTOS CABERNET"),
											("ELEMENTOS MALBEC"),
											("ELEMENTOS TINTO DULCE"),
											("EMILIA CABERNET"),
											("EMILIA EXTRA BRUT"),
											("EMILIA MALBEC"),
											("EMILIA ROSADO"),
											("ESCORIHUELA GASCON MALBEC"),
											("ESTIBA 1 CABERNET"),
											("ESTIBA 1 MALBEC"),
											("ETCHART PRIVADO TORRONTES"),
											("FABRE MONTMAYOU CABERNET"),
											("FABRE MONTMAYOU MALBEC"),
											("FAMILIA GASCON CABERNET"),
											("FAMILIA GASCON MALBEC"),
											("FEDERICO BRUT"),
											("FEDERICO DULCE"),
											("FEDERICO EB x2 + COPA"),
											("FEDERICO EXTRA BRUT"),
											("FEDERICO EXTRA DULCE"),
											("FEDERICO ROSADO DULCE"),
											("FELIPE RUTINI x botella"),
											("FERNET 1882"),
											("FERNET BRANCA 750"),
											("FERNET BRANCA MENTA 450"),
											("FERNET BRANCA MENTA 750"),
											("FERNET BRANCA MINIATURA"),
											("FERNET BRANCA X 1000"),
											("FERNET BRANCA X 450"),
											("FERNET BRANCA X 750 ESTUCHE CARTON DIA AMIGO"),
											("FERNET CAPRI X 450"),
											("FERNET CAPRI X 750"),
											("FERNET NERO 53"),
											("FERNET RAMAZZOTTI"),
											("FERNET VITTONE X 1000"),
											("FERNET VITTONE X 450"),
											("FERNET VITTONE X 750"),
											("FINLANDIA"),
											("FOND DE CAVE CABERNET"),
											("FOND DE CAVE MALBEC"),
											("FOND DE CAVE RESERVA MALBEC"),
											("FRANGELICO"),
											("FRESITA"),
											("FRIZZE BLUE"),
											("GANCIA RED BITTER"),
											("GIN BOMBAY "),
											("GIN GORDONS"),
											("GIN HIRAM WALKER"),
											("GINEBRA BOLS"),
											("GINEBRA LLAVE CRISTAL 475"),
											("GINEBRA LLAVE CRISTAL 950"),
											("GLENFIDICH"),
											("GRANADINA COUSENIER"),
											("GRANADINA TIP TOP"),
											("HAVANA 3 AÑOS AMARILLO 750"),
											("HAVANA 7 AÑOS"),
											("HAVANA DORADO AÑEJO"),
											("HEINEKEN LATA 500"),
											("HEINEKEN PORRON"),
											("HESPERIDINA 1000"),
											("IMAGO RED BLEND"),
											("IMPERIAL LATA 500"),
											("J&B 1000"),
											("J&B 750"),
											("JACK DANIELS 1000"),
											("JACK DANIELS 750"),
											("JACK DANIELS BOTELLON 1.75"),
											("JACK DANIELS CIDER"),
											("JACK DANIELS FIRE"),
											("JACK DANIELS HONEY"),
											("JACK DANIELS HONEY 750"),
											("JACK DANIELS LATA"),
											("JACK DANIELS SILVER"),
											("JACK DANIELS SINATRA"),
											("JACK DANIELS SINGLE BARREL"),
											("JAGUERMASTER"),
											("JAGUERMASTER 1.75L"),
											("JAGUERMASTER SPICE"),
											("JAMESON 1000"),
											("JAMESON 750"),
											("JAMESON GOLD RESERVE"),
											("JIM BEAM BLANCO X750"),
											("JIM BEAM NEGRO"),
											("JIM BEAM X 1LT"),
											("JOHNNIE WALKER BLACK 1000"),
											("JOHNNIE WALKER BLACK 750 LIMITED EDITION"),
											("JOHNNIE WALKER BLUE TIFFANY"),
											("JOHNNIE WALKER DOBLE BLACK 1000"),
											("JOHNNIE WALKER DOBLE BLACK 750"),
											("JOHNNIE WALKER EXPLORERS ADVENTURER"),
											("JOHNNIE WALKER GOLD"),
											("JOHNNIE WALKER GREEN X 750"),
											("JOHNNIE WALKER PLATINUM"),
											("JOHNNIE WALKER RED 1000"),
											("JOHNNIE WALKER RED 750"),
											("JOHNNIE WALKER SWING"),
											("JOSE CUERVO BLANCO"),
											("JOSE CUERVO DORADO"),
											("JOSE CUERVO ROLLING STONES"),
											("JUGO DE LIMON LIMONEL 1000"),
											("JUGO DE LIMON LIMONEL 500"),
											("JURA 10 AñOS"),
											("KOVAC"),
											("LA LINDA CABERNET"),
											("LA LINDA CHARDONNAY"),
											("LA LINDA EXTRA BRUT"),
											("LA LINDA MALBEC"),
											("LA LINDA SIRAH"),
											("LA LINDA TEMPRANILLO"),
											("LAGARDE DOLCE"),
											("LAGARDE GUARDA BLEND"),
											("LAS MORAS BLANCO DULCE"),
											("LAS MORAS CABERNET"),
											("LAS MORAS MALBEC"),
											("LAS PERDICES CABERNET"),
											("LAS PERDICES MALBEC"),
											("LATITUD CABERNET"),
											("LATITUD COSECHA TARDIA"),
											("LATITUD MALBEC"),
											("LATITUD MERLOT"),
											("LATITUD SIRAH"),
											("LEGUI"),
											("LOLA MONTES WHITE"),
											("LOPEZ BLANCO"),
											("LOPEZ MALBEC"),
											("LOS ARBOLES CABERNET"),
											("LOS ARBOLES MALBEC"),
											("LOS HAROLDOS NAMPE CABERNET"),
											("LOS HAROLDOS NAMPE MALBEC"),
											("LOVE CABERNET"),
											("LOVE MALBEC"),
											("LUIGI BOSCA CAB - MAL"),
											("LUIGI BOSCA CABERNET"),
											("LUIGI BOSCA MALBEC"),
											("LUIGI BRUT"),
											("LUIGI ESTUCHE 3 - BN - PR - BRUT"),
											("LUIGI ESTUCHE CAB Y MERLOT"),
											("LUIGI EXTRA BRUT"),
											("LUIGI NATURE"),
											("LUIGI PRESTIGE ROSE"),
											("MALIBU"),
											("MARIA CODORNIU EXTRA BRUT"),
											("MARIPOSA"),
											("MARKER MARK BOURBON"),
											("MARTINI EXTRA BRUT"),
											("MEZCAL ORO DE OAXACA (GUSANITO"),
											("MILLER PORRON"),
											("MOET CHANDON IMPERIAL"),
											("MUMM BRUT ROSE"),
											("MUMM DEMI SEC"),
											("MUMM EXTRA BRUT"),
											("NAVARRO ALEGORIA MALBEC"),
											("NAVARRO CORREA EXTRA BRUT"),
											("NAVARRO CORREA MALBEC"),
											("NAVARRO CORREA TRIVARIETAL"),
											("NEW AGE"),
											("NICASIA CABERNET FRANC"),
											("NICASIA MALBEC BLEND"),
											("NIETO BRUT NATURE"),
											("NIETO EXTRA BRUT"),
											("NIETO NATURE"),
											("NIETO SENETINER CABERNET"),
											("NIETO SENETINER MALBEC"),
											("NORTON COSECHA ESPECIAL"),
											("NORTON COSECHA TARDIA"),
											("NORTON TINTO DULCE"),
											("NOVECENTO EXTRA BRUT"),
											("OLD PARR x 1L"),
											("OLD SMUGLER 1000"),
											("OLD SMUGLER PETACA"),
											("OTARD DUPUY"),
											("OTTONE 450"),
											("OTTONE 750"),
											("PAZ MALBEC"),
											("PECADO CABERNET"),
											("PECADO MALBEC"),
											("PHEBUS MALBEC"),
											("PIÑA COLADA MOONLIGHT"),
											("PIONEER 1000"),
											("PORRON STELLA ARTOIS"),
											("PREMIUM"),
											("PUNTEMES"),
											("QUARA COSECHA TARDIA"),
											("QUARA MALBEC"),
											("QUILMES LATA 500"),
											("QUILMES PORRON"),
											("RED BULL"),
											("RENAISSANCE EXTRA BRUT"),
											("RESERVA DE LOS ANDES CABERNET"),
											("RESERVA DE LOS ANDES MALBEC"),
											("RESERVA SAN JUAN"),
											("RUTINI CAB-MAL"),
											("RUTINI COLECCION MALBEC"),
											("RUTINI ENCUENTRO MALBEC"),
											("SAINT FELICIEN CABERNET"),
											("SAINT FELICIEN MALBEC"),
											("SALENTEIN BRUT NATURE"),
											("SALENTEIN CABERNET"),
											("SALENTEIN EXTRA BRUT"),
											("SALENTEIN MALBEC"),
											("SALENTEIN MERLOT"),
											("SALENTEIN PINOT NOIR"),
											("SAN FELIPE 12 UVAS"),
											("SAN FELIPE BLANCO"),
											("SAN FELIPE CABERNET"),
											("SAN FELIPE MALBEC"),
											("SAN FELIPE TINTO"),
											("SAN HUBERTO CABERNET"),
											("SAN HUBERTO MALBEC"),
											("SANTA JULIA CABERNET"),
											("SANTA JULIA CHENIN"),
											("SANTA JULIA MALBEC"),
											("SANTA JULIA RESERVA MALBEC"),
											("SAURUS EXTRA BRUT"),
											("SAUZA GOLD"),
											("SAUZA SILVER"),
											("SCHNEIDER LATA 500"),
											("SENSACION EXTRA BRUT"),
											("SEPTIMA CABERNET"),
											("SEPTIMA EXTRA BRUT"),
											("SEPTIMA MALBEC"),
											("SEPTIMA OBRA MALBEC"),
											("SHERIDANS"),
											("SKYY"),
											("SMIRNOFF"),
											("SMIRNOFF CITRUS"),
											("SMIRNOFF GREEN APPLE"),
											("SMIRNOFF RASPBERRY"),
											("SOL AZTECA"),
											("SOL PORRON"),
											("SPEED"),
											("STREGGA DI LIMONE X 700"),
											("TANQUERAY"),
											("TEACHERS"),
											("TERRAZAS CABERNET"),
											("TERRAZAS MALBEC"),
											("TERRAZAS MERLOT"),
											("TERRAZAS RESERVA CABERNET"),
											("TERRAZAS RESERVA MALBEC"),
											("TERRAZAS SYRAH"),
											("THE FAMOUS GROUSE"),
											("THE GLENLIVET RESERVE"),
											("TIA MARIA"),
											("TIA MARIA CREAM"),
											("TRAPICHE ALARIS CABERNET"),
											("TRAPICHE ALARIS MALBEC"),
											("TRAPICHE ORIGEN CABERNET"),
											("TRAPICHE ORIGEN MALBEC"),
											("TRAPICHE RESERVA MALBEC"),
											("TRUMPETER CABERNET"),
											("TRUMPETER CHARDONAY"),
											("TRUMPETER MALBEC"),
											("TRUMPETER MERLOT"),
											("TRUMPETER RESERVA CABERNET"),
											("TRUMPETER RESERVA MALBEC"),
											("UXMAL CABERNET"),
											("UXMAL MALBEC"),
											("VALMONT BLANCO"),
											("VALMONT TINTO"),
											("VASCO VIEJO"),
											("VAT 69"),
											("VEUVE CLICQUOT BRUT"),
											("VODKA HIRAM WALKER"),
											("WHISKY CANADIAN CLUB 6 Y. O."),
											("WHISKY CARDHU"),
											("WHISKY GRANTS ALe Cask"),
											("WHISKY GRANTS FAMILY RESERVE"),
											("WHISKY GRANTS SHERRY CASK"),
											("WHISKY HIRAM WALKER"),
											("WHITE HORSE"),
											("WYBOROWA");
                                            
#Store Procedures
DELIMITER //

CREATE PROCEDURE actualizarPago (IN _id_pedido INT, IN _total_a_pagar DECIMAL(10,2), IN _cantidad_paga DECIMAL(10,2), _pagadoTot INT)
BEGIN

	IF(_pagadoTot = 1)
    THEN
		SET @_valorPedido = (SELECT precio FROM Pedidos WHERE id_pedido = _id_pedido);
		UPDATE Pedidos SET pagadoHastaElMomento = @_valorPedido WHERE id_pedido = _id_pedido;
    ELSE
		UPDATE Pedidos SET pagadoHastaElMomento = _cantidad_paga WHERE id_pedido = _id_pedido;
    END IF;
    
    IF(_cantidad_paga != 0)
	THEN
		CALL agregarEfectivo(_cantidad_paga, CONCAT("Un cliente pagó un pedido en la fecha ", CURDATE(), "."));
	END IF;
    
END //

CREATE PROCEDURE obtenerStock (IN _nombre VARCHAR(50)) 
BEGIN

	SELECT id_producto, cantidad, cantidadXBulto, nombre, costo, PVUnitario, PVBulto
	FROM Productos 
	WHERE ((nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
    AND deleted = 0 AND cantidad != 0;
    
END //

CREATE PROCEDURE obtenerStockPedido (IN _nombre VARCHAR(50)) 
BEGIN

	SELECT id_producto, cantidad, cantidadXBulto, nombre, costo, PVUnitario, PVBulto
	FROM Productos 
	WHERE ((nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
    AND deleted = 0;

END //

CREATE PROCEDURE agregarStock (IN _cantidad INT, IN _cantidadXBulto INT, IN _costo DECIMAL(10,2), IN _nombre VARCHAR(100), IN _PVUnitario DECIMAL(10,2), IN _PVBulto DECIMAL(10,2), IN _radioSelected INT) 
BEGIN

SET @_id_producto = (SELECT id_producto FROM Productos WHERE nombre = _nombre AND cantidadXBulto = _cantidadXBulto AND cantidadXBulto != 0);
	IF(@_id_producto IS NULL) THEN
		SET @_otro_id_producto = (SELECT id_producto FROM Productos WHERE nombre = _nombre AND cantidadXBulto = 0);
		IF(@_otro_id_producto IS NOT NULL AND _cantidadXBulto = 0) THEN
			#Es un producto individual existente.
            SET @_cantidadVieja = (SELECT cantidad FROM Productos WHERE id_producto = @_otro_id_producto);
            SET @_costoViejo = (SELECT costo FROM Productos WHERE id_producto = @_otro_id_producto);
            IF(@_costoViejo < _costo)
            THEN
				UPDATE Productos SET cantidad = _cantidad + @_cantidadVieja, costo = _costo, PVUnitario = _PVUnitario WHERE id_producto = @_otro_id_producto ;
            ELSE
				UPDATE Productos SET cantidad = _cantidad + @_cantidadVieja, PVUnitario = _PVUnitario WHERE id_producto = @_otro_id_producto ;
            END IF;
		ELSE
			#Es un producto nuevo.
			INSERT INTO Productos (cantidad, cantidadXBulto, costo, nombre, PVUnitario, PVBulto, radioSelected) VALUES (_cantidad, _cantidadXBulto, _costo, _nombre, _PVUnitario, _PVBulto, _radioSelected);
        END IF;
    ELSE
		#Es un Bulto con un _cantidadXBulto ya existente
		SET @_cantidadVieja = (SELECT cantidad FROM Productos WHERE id_producto = @_id_producto);
        SET @_costoViejo = (SELECT costo FROM Productos WHERE id_producto = @_otro_id_producto);
            IF(@_costoViejo < _costo)
            THEN
				UPDATE Productos SET cantidad = _cantidad + @_cantidadVieja, costo = _costo, PVBulto = _PVBulto, PVUnitario = _PVUnitario WHERE id_producto = @_id_producto;
            ELSE
				UPDATE Productos SET cantidad = _cantidad + @_cantidadVieja, PVBulto = _PVBulto, PVUnitario = _PVUnitario WHERE id_producto = @_id_producto;
            END IF;
    END IF;
END //

CREATE PROCEDURE borrarStock (IN _id_producto INT) 
BEGIN

	UPDATE Productos SET deleted = 1 WHERE id_producto = _id_producto;

END //

CREATE PROCEDURE obtenerProducto (IN _id_producto INT) 
BEGIN

	SELECT 
    cantidad, cantidadXBulto, nombre, costo, PVUnitario, PVBulto, radioSelected
FROM
    Productos
WHERE
    id_producto = _id_producto;
    
END //

CREATE PROCEDURE cargarGrillaClientes (IN _nombre VARCHAR(255), _apellido VARCHAR(50), _direccion VARCHAR(255))
BEGIN

	SELECT c.id_cliente, c.nombre AS Nombre, c.apellido AS Apellido, c.email AS Mail, c.telefono AS Teléfono, c.direccion AS Dirección, c.localidad AS Localidad, c.cuit as CUIT, c.razonSocial AS Razon_Social FROM Clientes c
	WHERE c.deleted = 0 AND ((c.nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
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

	SELECT CONCAT(nombre," ",apellido), email, telefono, direccion, localidad, cuit, razonSocial FROM Clientes WHERE id_cliente = _id_cliente;
END //

CREATE PROCEDURE cargarGrillaFacturas (IN _nombre VARCHAR(255), _apellido VARCHAR(255), _descripcion VARCHAR(50), _direccion VARCHAR(255))
BEGIN
	SELECT f.id_factura, c.id_cliente, CONCAT(c.nombre, " ", c.apellido) AS Nombre, f.tipoDeFactura AS 'Tipo de factura', p.precio AS Precio, group_concat(pr.nombre) AS 'Productos de Factura' FROM Facturas f
	INNER JOIN Pedidos p ON p.id_pedido = f.pedido
	INNER JOIN Clientes c ON p.comprador = c.id_cliente
	INNER JOIN Items i ON p.id_pedido = i.pedido
	INNER JOIN Productos pr ON i.producto = pr.id_producto
	WHERE ((f.tipoDeFactura LIKE CONCAT("%", _descripcion, "%") COLLATE utf8_general_ci ) OR (_descripcion IS NULL OR _descripcion = ""))
	AND ((CONCAT(c.nombre, " ", c.apellido) LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
	AND ((c.apellido LIKE CONCAT("%", _apellido, "%") COLLATE utf8_general_ci ) OR (_apellido IS NULL OR _apellido = ""))
	AND ((c.direccion LIKE CONCAT("%", _direccion, "%") COLLATE utf8_general_ci) OR (_direccion IS NULL OR _direccion = ""))
    GROUP BY p.id_pedido
    ORDER BY f.id_factura ASC
    LIMIT 20000;
END //

CREATE PROCEDURE agregarEfectivo (IN _montoASumar INT, _descripcion VARCHAR(200)) 
BEGIN

SET @_efectivo = (SELECT efectivoActual FROM Caja WHERE id_caja = 1);

UPDATE Caja 
SET 
    efectivoActual = (@_efectivo + _montoASumar)
WHERE
    id_caja = 1;
    INSERT INTO Operaciones (fecha, operacion, descripcion) VALUES (NOW(), "Efectivo entrante", CONCAT(_descripcion, " por el valor de $ ", _montoASumar));

END //

CREATE PROCEDURE restarEfectivo (IN _montoARestar INT, _descripcion VARCHAR(200)) 
BEGIN

	SET @_efectivo = (SELECT efectivoActual FROM Caja WHERE id_caja = 1);

    UPDATE Caja SET efectivoActual = (@_efectivo - _montoARestar) WHERE id_caja=1;
    INSERT INTO Operaciones (fecha, operacion, descripcion) VALUES (NOW(), "Efectivo saliente", CONCAT(_descripcion, " por el valor de $ ", _montoARestar));
END //

CREATE PROCEDURE obtenerMontoEnEfectivo () 
BEGIN

	SELECT efectivoActual FROM Caja WHERE id_caja = 1;

END //

CREATE PROCEDURE obtenerMontoEnProductos () 
BEGIN

	SELECT SUM(costo * cantidad) FROM Productos;

END //

CREATE PROCEDURE cargarGrillaDeOperaciones (IN  _operacion VARCHAR(255), _descripcion VARCHAR(50))
BEGIN
	SELECT fecha AS Fecha, operacion AS Operación, descripcion AS Descripción FROM Operaciones
	WHERE ((descripcion LIKE CONCAT("%", _descripcion, "%") COLLATE utf8_general_ci ) OR (_descripcion IS NULL OR _descripcion = ""))
	AND ((operacion LIKE CONCAT("%", _operacion, "%") COLLATE utf8_general_ci ) OR (_operacion IS NULL OR _operacion = ""))
    ORDER BY id_operacion ASC
    LIMIT 20000;
END //

CREATE PROCEDURE obtenerPedidos (_nombre VARCHAR(50)) 
BEGIN
        SELECT p.id_pedido, CONCAT(c.nombre, " ", c.apellido), p.pagadoHastaElMomento, p.precio - p.pagadoHastaElMomento, group_concat(pr.nombre), p.facturada FROM Pedidos p 
        LEFT JOIN Facturas f ON p.id_pedido = f.pedido
        INNER JOIN Clientes c ON p.comprador = c.id_cliente
        INNER JOIN Items i ON p.id_pedido = i.pedido
        INNER JOIN Productos pr ON i.producto = pr.id_producto
        WHERE ((c.nombre LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
        GROUP BY p.id_pedido
        ORDER BY p.id_pedido ASC
		LIMIT 20000;
END //

CREATE PROCEDURE borrarPedido (IN _id_pedido INT)
BEGIN

SET @_montoARemover = (SELECT pagadoHastaElMomento FROM Pedidos WHERE id_pedido = _id_pedido);

	CALL restarEfectivo (@_montoARemover, "Manejo interno del programa - se esta modificando un pedido.");

	DELETE FROM Items WHERE pedido = _id_pedido;
	DELETE FROM Pedidos WHERE id_pedido = _id_pedido;

END //

CREATE PROCEDURE agregarNuevoProducto(IN _nombre VARCHAR(60))
BEGIN
	INSERT INTO ListaDeProductos(descripcion) VALUES (_nombre);
END //

CREATE PROCEDURE crearPedido (IN _id_comprador INT, IN _pagadoHastaElMomento DECIMAL(10,2), IN _precio DECIMAL(10,2))
BEGIN

	IF(_pagadoHastaElMomento > 0)
    THEN
		CALL agregarEfectivo(_pagadoHastaElMomento, "El cliente pagó ");
	END IF;
    
	INSERT INTO Pedidos (comprador, pagadoHastaElMomento, precio) VALUES (_id_comprador, _pagadoHastaElMomento, _precio);
	SELECT LAST_INSERT_ID();
    
END //

CREATE PROCEDURE agregarItemAPedido (IN _id_pedido INT, IN _id_producto INT, IN _cantidad INT, _valorDelItem decimal)
BEGIN

SET @_nuevaCantidad = (SELECT cantidad FROM Productos WHERE id_producto = _id_producto) - _cantidad;

	UPDATE Productos SET cantidad = @_nuevaCantidad WHERE id_producto = _id_producto;
	INSERT INTO Items (producto, pedido, cantidadProductos, cantidadProductosEdit, valorDelItem) VALUES (_id_producto, _id_pedido, _cantidad, _cantidad, _valorDelItem);

END //

CREATE PROCEDURE generarFactura (IN _id_pedido INT, IN _tipoFactura VARCHAR(60))
BEGIN

	INSERT INTO Facturas (fecha, tipoDeFactura, pedido) VALUES (CURTIME(), _tipoFactura, _id_pedido);
    INSERT INTO Operaciones (fecha, operacion, descripcion) VALUES (NOW(), "Generación de factura", "Factura Creada"); 
    UPDATE Pedidos SET facturada = 1 WHERE _id_pedido = id_pedido;
END //

CREATE PROCEDURE obtenerDatosDeUnPedido (IN _id_pedido INT)
BEGIN

	SELECT pagadoHastaElMomento, precio, comprador FROM Pedidos WHERE id_pedido = _id_pedido;
    
END //

CREATE PROCEDURE obtenerItems (IN _id_pedido INT)
BEGIN

	SELECT pr.id_producto, pr.cantidadProductos, i.valorDelItem FROM Items i
    INNER JOIN Productos pr ON pr.id_producto = i.producto
    WHERE i.pedido = _id_pedido AND pr.cantidadProductos != 0;
    
END //

CREATE PROCEDURE updatearStock (IN _id_producto INT, IN _cantidad INT)
BEGIN

SET @_nuevaCantidad = (SELECT cantidad FROM Productos WHERE id_producto = _id_producto) + _cantidad;

	UPDATE Productos SET cantidad = @_nuevaCantidad WHERE id_producto = _id_producto;
    
END //

CREATE PROCEDURE obtenerInfoItems (IN _id_producto INT)
BEGIN

	SELECT id_producto, nombre, PVUnitario, PVBulto, cantidadXBulto FROM Productos WHERE id_producto = _id_producto;

END //

CREATE PROCEDURE obtenerFactura (IN _id_factura INT)
BEGIN
	SELECT f.tipoDeFactura, p.precio FROM Facturas f
    INNER JOIN Pedidos p ON p.id_pedido = f.pedido
    WHERE f.id_factura = _id_factura; 
END //

CREATE PROCEDURE obtenerItemsDeFactura (IN _id_factura INT)
BEGIN

	CREATE TEMPORARY TABLE ItemsDeFac(
		nombre VARCHAR(50),
        cantidadPr INT DEFAULT 0,
        precioUnitario DECIMAL(18,2) DEFAULT 0,
        precioBulto DECIMAL(18,2) DEFAULT 0,
        precioTotal DECIMAL(18,2) DEFAULT 0
	);
	
	INSERT INTO ItemsDeFac SELECT pr.nombre AS Nombre, i.cantidadProductos AS 'Cantidad Total',
		   IF(PVBulto = 0, PVUnitario, Round(PVBulto / cantidadXBulto, 2)) AS 'Precio Unitario',
           IF(PVBulto = 0, 0, Round(PVUnitario * cantidadXBulto, 2)) AS 'Precio Bulto',
		   IF(PVBulto = 0, Round(PVUnitario * i.cantidadProductos, 2), Round(PVBulto * i.cantidadProductos, 2)) AS 'Precio Total'
	FROM Facturas f
    INNER JOIN Pedidos p ON p.id_pedido = f.pedido
    INNER JOIN Items i ON i.pedido = p.id_pedido
    INNER JOIN Productos pr ON pr.id_producto = i.producto
    WHERE f.id_factura = _id_factura
    GROUP BY i.id_item;
    
    
    INSERT INTO ItemsDeFac(nombre,precioTotal) 
    SELECT "Nota de credito", importe FROM NotasDeCredito
    WHERE factura = _id_factura;
    
	SELECT 
    nombre AS 'DESCRIPCION',
    IF(cantidadPr = 0, '-', cantidadPr) AS 'CANT. TOT.',
    IF(precioUnitario = 0,
        '-',
        precioUnitario) AS 'PRECIO UNITARIO',
    IF(precioBulto = 0, '-', precioBulto) AS 'PRECIO BULTO',
    precioTotal AS 'PRECIO TOTAL'
FROM
    ItemsDeFac;
    
    DROP TABLE ItemsDeFac;
    
END //

CREATE PROCEDURE obtenerItemsDeFacturaSinNC (IN _id_factura INT)
BEGIN
SELECT pr.id_producto, pr.nombre AS Nombre, i.cantidadProductosEdit AS 'Cantidad Total',
		   IF(PVBulto = 0, PVUnitario, Round(PVBulto / cantidadXBulto, 2)) AS 'Precio Unitario',
           IF(PVBulto = 0, 0, Round(PVUnitario * cantidadXBulto, 2)) AS 'Precio Bulto',
		   IF(PVBulto = 0, Round(PVUnitario * cantidadProductos,2), Round(PVBulto * cantidadProductos,2)) AS 'Precio Total'
	FROM Facturas f
    INNER JOIN Pedidos p ON p.id_pedido = f.pedido
    INNER JOIN Items i ON i.pedido = p.id_pedido
    INNER JOIN Productos pr ON pr.id_producto = i.producto
    WHERE f.id_factura = _id_factura
    GROUP BY i.id_item;
END //

CREATE PROCEDURE agregarCantidad (IN _id_producto INT, _cantidad INT, _id_factura INT)
BEGIN
	SET @_cantidadVieja = (SELECT cantidad FROM Productos WHERE id_producto = _id_producto);
	UPDATE Productos 
SET 
    cantidad = _cantidad + @_cantidadVieja
WHERE
    id_producto = _id_producto;
    
	SET @_cantidadDePrEdit = ( SELECT i.cantidadProductosEdit FROM Items i INNER JOIN Pedidos p ON i.pedido = p.id_pedido
																 INNER JOIN Facturas f ON p.id_pedido = f.pedido 
																 INNER JOIN Productos pr ON pr.id_producto = i.producto
                                                                 WHERE f.id_factura = _id_factura AND pr.id_producto = _id_producto);
    
    UPDATE Items i
    INNER JOIN Pedidos p ON i.pedido = p.id_pedido
    INNER JOIN Facturas f ON p.id_pedido = f.pedido 
    INNER JOIN Productos pr ON pr.id_producto = i.producto
    SET i.cantidadProductosEdit = @_cantidadDePrEdit - cantidad
    WHERE f.id_factura = _id_factura AND pr.id_producto = _id_producto;
    
END//

CREATE PROCEDURE obtenerLista (IN _nombre VARCHAR(60))
BEGIN
	#retorna id_producto (0), descripcion(1), tipo(2)(wut), 3 - costo, 	4 - precio unitario, 5- precio bulto, 6-radioSelected
	SELECT p.id_producto, descripcion AS Descripción, IF(PVunitario IS NULL,'N/E',IF(cantidadXBulto = 0, 'Individual',cantidadXBulto)) AS 'Tipo', IF(costo IS NULL,'N/E',costo) AS Costo, IF(PVunitario IS NULL,'N/E',PVUnitario) AS 'Precio Unitario', IF(PVBulto IS NULL, 'N/E', IF(PVBulto = 0,'-',PVBulto)) AS 'Precio Bulto', radioSelected AS 'RadioSelected' FROM ListaDeProductos lp
    LEFT JOIN Productos p ON lp.descripcion = p.nombre
	WHERE ((descripcion LIKE CONCAT("%", _nombre, "%") COLLATE utf8_general_ci ) OR (_nombre IS NULL OR _nombre = ""))
    ORDER BY descripcion;
END //

CREATE PROCEDURE crearPedidoDeLea (IN _costo DECIMAL(10,2), _id_vendedor INT)
BEGIN

	INSERT INTO PedidosDeLea (fecha, costo, vendedor) VALUES (NOW(), _costo, _id_vendedor);
	SELECT LAST_INSERT_ID();
    
END //

CREATE PROCEDURE crearItemDeLea (IN _id_pedidoLea INT, IN _cantidad INT, IN _cantidadXBulto INT, IN _costo DECIMAL(10,2), IN _nombre VARCHAR(100), IN _PVUnitario DECIMAL(10,2), IN _PVBulto DECIMAL (10,2), IN _radioSelected INT)
BEGIN
    
    INSERT INTO StockACargar (cantidad, cantidadXBulto, costo, nombre, PVUnitario, PVBulto, radioSelected) VALUES (_cantidad, _cantidadXBulto, _costo, _nombre, _PVUnitario, _PVBulto, _radioSelected);
    SET @_id_stockACargar = LAST_INSERT_ID();

    INSERT INTO ItemsDeLea (id_pedido, id_stockACargar) VALUES (_id_pedidoLea, @_id_stockACargar);

END //

CREATE PROCEDURE cobrarPedidoDeLea(IN _id_pedido INT)
BEGIN
	SET @_costo = (SELECT costo FROM PedidosDeLea WHERE id_pedido = _id_pedido);
    UPDATE PedidosDeLea SET pagado = 1 WHERE id_pedido = _id_pedido;
	CALL restarEfectivo (@_costo , CONCAT("Se realizo una pedido de compra"));
END //

CREATE PROCEDURE obtenerItemsDeLea (IN _id_pedidoLea INT)
BEGIN

	SELECT sac.cantidadXBulto, sac.nombre, sac.costo, sac.PVUnitario, sac.PVBulto, sac.cantidad, sac.radioSelected FROM ItemsDeLea iLea
    INNER JOIN StockACargar sac ON iLea.id_stockACargar = sac.id_stockACargar
    INNER JOIN PedidosDeLea pdl ON pdl.id_pedido = iLea.id_pedido
    WHERE pdl.id_pedido = _id_pedidoLea;

END //

CREATE PROCEDURE cargarPedidoCompras ()
BEGIN

	SELECT p.id_pedido, c.nombre AS Proveedor, p.fecha, group_concat(sac.nombre), p.costo, IF(p.pagado = 1, 'Si', 'No'), IF(p.stockCargado = 1, 'Si', 'No') FROM PedidosDeLea p 
    INNER JOIN ItemsDeLea i ON p.id_pedido = i.id_pedido
    INNER JOIN StockACargar sac ON sac.id_stockACargar = i.id_stockACargar
    INNER JOIN Clientes c ON c.id_cliente = p.vendedor
    GROUP BY p.id_pedido
    ORDER BY p.id_pedido ASC
	LIMIT 20000;

END //

CREATE PROCEDURE borrarPedidoDeLea (IN _id_pedidoLea INT)
BEGIN

	DELETE FROM ItemsDeLea WHERE id_pedido = _id_pedidoLea; 
    DELETE FROM PedidosDeLea WHERE id_pedido = _id_pedidoLea;

END //

CREATE PROCEDURE cargarDatosActualizarPago (IN _id_pedido INT)
BEGIN

	SELECT (precio - pagadoHastaElMomento),0 FROM Pedidos WHERE id_pedido = _id_pedido;

END //

CREATE PROCEDURE agregarNotaDeCredito (IN _id_factura INT, _cantidad DECIMAL(10 , 2), _motivo VARCHAR(50))
BEGIN
	INSERT INTO NotasDeCredito (factura, importe, motivo, fecha) VALUES (_id_factura, _cantidad, _motivo, NOW());
	
END //

CREATE PROCEDURE cargarNotasDeCredito(IN _id_factura INT)
BEGIN

	SELECT fecha AS Fecha, importe AS Importe, motivo AS Motivo FROM NotasDeCredito
    WHERE factura = _id_factura;
	
END //

CREATE PROCEDURE obtenerItemsDeRemito(IN _id_factura INT)
BEGIN
	SELECT pr.nombre AS DESCRIPCION, IF(0 > i.cantidadProductosEdit, 0, i.cantidadProductosEdit) AS 'CANT.'
	FROM Facturas f
    INNER JOIN Pedidos p ON p.id_pedido = f.pedido
    INNER JOIN Items i ON i.pedido = p.id_pedido
    INNER JOIN Productos pr ON pr.id_producto = i.producto
    WHERE f.id_factura = _id_factura
    GROUP BY i.id_item;
END //


CREATE PROCEDURE cargarStockPedidoLea (IN _id_pedido INT)
BEGIN

	DECLARE finished INT DEFAULT 0;
	DECLARE cantidad INT;
    DECLARE cantidadXBulto INT;
    DECLARE costo DECIMAL(10,2);
    DECLARE nombre VARCHAR(100);
    DECLARE PVUnitario DECIMAL(10,2);
	DECLARE PVBulto DECIMAL(10,2);
    DECLARE radioSelected INT;

	DECLARE row_cursor CURSOR FOR 
    SELECT sac.cantidad, sac.cantidadXBulto, sac.costo, sac.nombre, sac.PVUnitario, sac.PVBulto, sac.radioSelected FROM ItemsDeLea idl
    INNER JOIN StockACargar sac ON idl.id_stockACargar = sac.id_stockACargar
    WHERE id_pedido = _id_pedido;

	DECLARE CONTINUE HANDLER FOR NOT FOUND SET finished = 1;

	OPEN row_cursor;

	SET finished = 0;

        REPEAT	

			FETCH row_cursor INTO cantidad, cantidadXBulto, costo, nombre, PVUnitario, PVBulto, radioSelected;
			
			if ! finished then
				CALL agregarStock (cantidad, cantidadXBulto, costo, nombre, PVUnitario, PVBulto, radioSelected); 
			END IF;


	UNTIL finished END REPEAT;
	CLOSE row_cursor;

	UPDATE PedidosDeLea 
SET 
    stockCargado = 1
WHERE
    id_pedido = _id_pedido;
END //

DELIMITER ;