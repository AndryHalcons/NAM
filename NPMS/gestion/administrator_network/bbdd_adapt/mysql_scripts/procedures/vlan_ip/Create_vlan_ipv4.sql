DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Create_vlan_ipv4`(in id_vlan varchar(30),
in id_nombre_vlan varchar(100),in id_Ubicacion varchar(100),in id_Vsys varchar(100),
in id_Descripcion varchar(100),in id_DireccionRed varchar(100),in id_RangoInicio varchar(100),
in id_RangoFin varchar(100),in id_Mascara varchar(100),
in id_Gateway1 varchar(100),
in Broadcast varchar(100),
in id_Observaciones varchar(100),in id_Dispositivo varchar(100),in id_Firewall varchar(100),
in id_Entorno varchar(100),in id_Normativa varchar(100),in id_Estado varchar(100),
in id_TipoRed varchar(100),in id_Equipos varchar(100),in id_Clasificacion varchar(100),
in id_Tarea varchar(100),in id_Usuario varchar(100))
BEGIN
declare gateway_aton varchar(50);
set gateway_aton = inet_aton(id_Gateway1);
/*************insertar datos en tabla VLAN  *************/
SET @s = CONCAT("INSERT INTO `npms`.`vlan_ipv4` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
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
SET @log = CONCAT("INSERT INTO `npms`.`log_vlan_ipv4` (`Accion`,`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" ,
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
CREATE TABLE `",id_vlan,"` (
`ID` int(11) NOT NULL AUTO_INCREMENT,
`Vlan` int(11) NOT NULL,
`IP` varchar(30) NOT NULL,
`Ubicacion` varchar(150) DEFAULT NULL,
`Mac` varchar(30) DEFAULT NULL,
`DNS` varchar(150) DEFAULT NULL,
`Descripcion` varchar(150) DEFAULT NULL,
`Hostname_revisado` varchar(150) DEFAULT NULL,
`Hostname` varchar(150) DEFAULT NULL,
`Fecha_modificacion` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
`Tarea` varchar(150) DEFAULT NULL,
`usuario` varchar(150) DEFAULT NULL,
PRIMARY KEY (`ID`,`IP`),
UNIQUE KEY `IP_UNIQUE` (`IP`),
UNIQUE KEY `ID_UNIQUE` (`ID`)
)");
    PREPARE stmt FROM @Ctable;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
/* //////////////// Rellenar tabla ip ////////////////// */
call rellenar_tabla_ip_ipv4(id_RangoInicio,Broadcast,id_vlan);

   set @ingate1 = CONCAT("UPDATE `npms`.`",id_vlan,"` SET `Ubicacion` = 'gateway1', 
   `Mac` = 'Gateway1', 
   `DNS` = 'Gateway1', 
   `Descripcion` = 'Gateway1', 
   `Hostname_revisado` = 'Gateway1', 
   `Hostname` = 'Gateway1' 
   WHERE (`IP` = '",gateway_aton,"');");
    PREPARE stmt FROM @ingate1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
    

END$$
DELIMITER ;
