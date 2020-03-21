DELIMITER $$
CREATE PROCEDURE `Create_vlan_ipv6`(in id_vlan varchar(30),
in id_nombre_vlan varchar(100),in id_Ubicacion varchar(100),in id_Vsys varchar(100),
in id_Descripcion varchar(150),in id_DireccionRed varchar(150),in id_RangoInicio varchar(150),
in id_RangoFin varchar(150),in id_Mascara varchar(150),
in id_Gateway1 varchar(150),
in formateo_vlan varchar(150),
in id_Observaciones varchar(100),in id_Dispositivo varchar(100),in id_Firewall varchar(100),
in id_Entorno varchar(100),in id_Normativa varchar(100),in id_Estado varchar(100),
in id_TipoRed varchar(100),in id_Equipos varchar(100),in id_Clasificacion varchar(100),
in id_Tarea varchar(100),in id_Usuario varchar(100))
BEGIN
declare gateway_aton varchar(150);
set gateway_aton = HEX(INET6_ATON(id_Gateway1));

/*************insertar datos en tabla VLAN  *************/
SET @s = CONCAT("INSERT INTO `npms`.`vlan_ipv6` (`Vlan`, `Name`, 
`Location`, `Vsys/balancer/other`, `Description`, 
`Network`,`Initial_Range`, `Final_Range`, 
`Mask`, `Gateway`,`Observations`, `Device`, 
`Firewall`, `Environment`, `Normative`,`Status`, `Network_Type`,
 `Equipment`, `Classification`, `Work_Order`, `User`)" ,
"VALUES('" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;  
/********* SENTENCIA RELLENAR LOGS****************/
SET @log = CONCAT("INSERT INTO `npms`.`log_vlan_ipv6` (`Action`,`Vlan`,
 `Name`, `Location`, `Vsys/balancer/other`, `Description`,
 `Network`,`Initial_Range`, `Final_Range`, `Mask`,
 `Gateway`,`Observations`, `Device`, `Firewall`, 
 `Environment`, `Normative`,`Status`, `Network_Type`, `Equipment`,
 `Classification`, `Work_Order`, `User`)" ,
"VALUES('Create','" , id_vlan , "','" , id_nombre_vlan , "','" , id_Ubicacion , "','" , id_Vsys , "',
'" , id_Descripcion , "','" , id_DireccionRed , "','" , id_RangoInicio , "','" , id_RangoFin , "',
'" , id_Mascara , "',' " , id_Gateway1 , "','" , id_Observaciones , "','" , id_Dispositivo , "',
'" , id_Firewall , "','" , id_Entorno , "','" , id_Normativa , "',' " , id_Estado , "',
'" , id_TipoRed , "', '" , id_Equipos , "','" , id_Clasificacion , "', '" , id_Tarea , "', 
'" , id_Usuario , "');");
    PREPARE stmt FROM @log;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
   
    /************** CREAR TABLA IP ******************/
set @Ctable = CONCAT("
CREATE TABLE `",formateo_vlan,"` (
`ID` int(11) NOT NULL AUTO_INCREMENT,
`Vlan` int(11) NOT NULL,
`IP` varchar(150) NOT NULL,
`Location` varchar(150) DEFAULT NULL,
`Mac` varchar(150) DEFAULT NULL,
`DNS` varchar(150) DEFAULT NULL,
`Description` varchar(150) DEFAULT NULL,
`Revised_Hostname` varchar(150) DEFAULT NULL,
`Hostname` varchar(150) DEFAULT NULL,
`Date` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
`Work_Order` varchar(150) DEFAULT NULL,
`User` varchar(150) DEFAULT NULL,
PRIMARY KEY (`ID`,`IP`),
UNIQUE KEY `IP_UNIQUE` (`IP`),
UNIQUE KEY `ID_UNIQUE` (`ID`)
)");
    PREPARE stmt FROM @Ctable;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
/* //////////////// Rellenar tabla ip ////////////////// */
   set @ingate1 = CONCAT("INSERT INTO `npms`.`",formateo_vlan,"` 
   (`Vlan`, `IP`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
   VALUES ('" , id_vlan , "', '" , gateway_aton , "', 'Gateway', 
   'Gateway', 'Gateway', 'Gateway', 'Gateway', 'Gateway', '" , id_Tarea , "', '" , id_Usuario , "');");
    PREPARE stmt FROM @ingate1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
    

END$$
DELIMITER ;
