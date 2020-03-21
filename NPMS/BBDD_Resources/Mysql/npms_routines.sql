-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: npms
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping events for database 'npms'
--

--
-- Dumping routines for database 'npms'
--
/*!50003 DROP PROCEDURE IF EXISTS `create_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `create_user`(in usuario varchar (40),
in pass varchar (40),in rol varchar(100),
in for_user varchar(40))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`usuarios` (`User`, `Password`, `Rol`) 
VALUES ('",usuario,"', '",pass,"', '",rol,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
    
set @b = CONCAT("INSERT INTO `npms`.`log_user` 
(`Action`, `User`, `Rol`, `For_User`) 
VALUES ('Create', '",usuario,"', '",rol,"', '",for_user,"');");
PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Create_vlan_ipv4` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
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
SET @s = CONCAT("INSERT INTO `npms`.`vlan_ipv4` (`Vlan`, `Name`, `Location`, `Vsys/balancer/other`, 
`Description`, `Network`,`Initial_Range`, `Final_Range`,
`Mask`, `Gateway`,`Observations`, `Device`, 
`Firewall`, `Environment`, `Normative`,`Status`, 
`Network_Type`, `Equipment`, `Classification`, `Work_Order`, 
`User`)" ,
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
SET @log = CONCAT("INSERT INTO `npms`.`log_vlan_ipv4` (`Action`,`Vlan`, `Name`, 
`Location`, `Vsys/balancer/other`, 
`Description`, `Network`,`Initial_Range`, `Final_Range`, 
`Mask`, `Gateway`,`Observations`, `Device`, 
`Firewall`, `Environment`, `Normative`,`Status`, 
`Network_Type`, `Equipment`, `Classification`, `Work_Order`, 
`User`)" ,
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
`Location` varchar(150) DEFAULT NULL,
`Mac` varchar(30) DEFAULT NULL,
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
call rellenar_tabla_ip_ipv4(id_RangoInicio,Broadcast,id_vlan);

   set @ingate1 = CONCAT("UPDATE `npms`.`",id_vlan,"` SET `Location` = 'gateway1', 
   `Mac` = 'Gateway1', 
   `DNS` = 'Gateway1', 
   `Description` = 'Gateway1', 
   `Revised_Hostname` = 'Gateway1', 
   `Hostname` = 'Gateway1' 
   WHERE (`IP` = '",gateway_aton,"');");
    PREPARE stmt FROM @ingate1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
    

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Create_vlan_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Create_vlan_ipv6`(in id_vlan varchar(30),
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
    

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_all_building` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_all_building`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Action`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('Delete', '",Building,"', 'ALL', 'ALL',
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', 'ALL', 'ALL', 'ALL', 
 'ALL', '",VarUsuario,"', '",VarTarea,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE Building = '",Building,"';");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_all_closet` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_all_closet`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50),IN Floor varchar(50),IN Closet varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Action`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('",VarAccion,"', '",Building,"', '",Floor,"', '",Closet,"',
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', 'Closet_All', 'Closet_All', 'Closet_All', 
 'Closet_All', '",VarUsuario,"', '",VarTarea,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_all_floor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_all_floor`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50),IN Floor varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Action`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`)  
VALUES ('",VarAccion,"', '",Building,"', '",Floor,"', 'Floor_ALL',
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 'Floor_ALL', 
 'Floor_ALL', '",VarUsuario,"', '",VarTarea,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` WHERE (`Building` = '",Building,"' and `Floor` = '",Floor,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_field_patching` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_field_patching`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarTarea varchar(50),
IN Building varchar(50),IN Floor varchar(50),IN Closet varchar(50)
,IN Panel varchar(50),IN Panel_port varchar(50),IN Stack varchar(50),IN IP_switch varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`)  
select `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`
from `patching` where (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"'
and `Panel` = '",Panel,"' and `Panel_Port` = '",Panel_port,"' and `Stack` = '",Stack,"' and `IP_Switch` = '",IP_switch,"' );");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_patching);
UPDATE `npms`.`log_patching` SET `Action` = VarAccion, `WORK_ORDER` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id; 
 SET @s2 = CONCAT("DELETE FROM `npms`.`patching` where (`Building` = '",Building,"' and `Floor` = '",Floor,"' and `Closet` = '",Closet,"'
and `Panel` = '",Panel,"' and `Panel_Port` = '",Panel_port,"' and `Stack` = '",Stack,"' and `IP_Switch` = '",IP_switch,"' );");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `delete_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_user`(in Accion varchar (40),in Usuario varchar (40),in For_user varchar(100))
BEGIN

 SET @s = CONCAT("insert into `log_user`
(`User`,`Rol`)
select `User`, `Rol`
from `usuarios` where User ='", Usuario,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_user);
UPDATE `npms`.`log_user` SET `Action` = Accion, `For_User` = For_user WHERE `ID` = @max_id;   
SET @b = CONCAT("DELETE FROM `npms`.`usuarios` WHERE (`User` = '", Usuario,"');");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_inventory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_inventory`(in accion varchar(80),
in hostname varchar(80),in dns varchar(80),in comments varchar(80),in ip varchar(80),
in sn varchar(80),in nombre varchar(80),in manufacturer varchar(80),
in location varchar(80),in environment varchar(80),in domain varchar(80)
,in contact varchar(80),in aditionalinfo varchar(80),in ports varchar(80)
,in other1 varchar(80),in other2 varchar(80),in worder varchar(80),in usuario varchar(80))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`inventory` 
(`HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
VALUES 
('",hostname,"', '",dns,"', '",comments,"', '",ip,"', '",sn,"', '",nombre,"', 
'",manufacturer,"', '",location,"', '",environment,"', '",domain,"', '",contact,"', 
'",aditionalinfo,"', '",ports,"', '",other1,"', '",other2,"', '",worder,"', '",usuario,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b =  CONCAT("INSERT INTO `npms`.`log_inventory` 
(`ACTION`, `HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
VALUES 
('",accion,"', '",hostname,"', '",dns,"', '",comments,"', '",ip,"', '",sn,"', '",nombre,"', 
'",manufacturer,"', '",location,"', '",environment,"', '",domain,"', '",contact,"', 
'",aditionalinfo,"', '",ports,"', '",other1,"', '",other2,"', '",worder,"', '",usuario,"');");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_ip_ipv4` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ip_ipv4`(in id_accion varchar(30),
in id_vlan varchar(30),in id_ip varchar(30),in id_Ubicacion varchar(30),in id_mac varchar(30),
in id_dns varchar(30),in id_Descripcion varchar(30),in id_hostnameR varchar(30),
in id_hostname varchar(30),in id_Tarea varchar(30),in id_usuario varchar(30))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(id_ip);
SET @s = CONCAT("UPDATE `npms`.`",id_vlan,"` SET 
`Location` = '",id_Ubicacion,"', 
`Mac` = '",id_mac,"', 
`DNS` = '",id_dns,"', 
`Description` = '",id_Descripcion,"', 
`Revised_Hostname` = '",id_hostnameR,"', 
`Hostname` = '",id_hostname,"', 
`Work_Order` = '",id_Tarea,"', 
`User` = '",id_usuario,"' 
WHERE (`IP` = '",ip_aton,"');

");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
    
SET @c = CONCAT("INSERT INTO `npms`.`domain_name` 
(`Vlan`, `IP`, `DNS`, `Hostname`) VALUES 
('",id_vlan,"', '",id_ip,"', '",id_dns,"', '",id_hostname,"');");
    PREPARE stmt FROM @c;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;    

SET @b = CONCAT("INSERT INTO `npms`.`log_ip_ipv4` 
(`IP`, `Action`, `Vlan`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
VALUES ('",ip_aton,"', '",id_accion,"', '",id_vlan,"','",id_Ubicacion,"',
'",id_mac,"', '",id_dns,"', '",id_Descripcion,"', '",id_hostnameR,"', '",id_hostname,"', 
'",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_ip_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ip_ipv6`(in id_accion varchar(80),
in id_vlan varchar(80),in id_ip varchar(80),in id_Ubicacion varchar(80),in id_mac varchar(100),
in id_dns varchar(80),in id_Descripcion varchar(80),in id_hostnameR varchar(80),
in id_hostname varchar(80),in id_Tarea varchar(80),in id_usuario varchar(80),in id_FormateoTabla varchar(80))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`",id_FormateoTabla,"` (`Vlan`, `IP`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
VALUES ('",id_vlan,"', '",id_ip,"','",id_Ubicacion,"', '",id_mac,"','",id_dns,"','",id_Descripcion,"', 
'",id_hostnameR,"', '",id_hostname,"', '",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_ip_ipv6` 
(`IP`, `Action`, `Vlan`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
VALUES ('",id_ip,"', '",id_accion,"', '",id_vlan,"','",id_Ubicacion,"',
'",id_mac,"', '",id_dns,"', '",id_Descripcion,"', '",id_hostnameR,"', '",id_hostname,"', 
'",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insert_patching` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_patching`(in Building varchar(30),
in Floor varchar(30),in Closet varchar(30),in Panel varchar(30),in Panel_Port varchar(30),
in Stack varchar(30),in Switch varchar(30),in Switch_Port varchar(30),
in Interfaz varchar(30),in Link varchar(30),in Speed varchar(30)
,in Duplex varchar(30),in Type_ varchar(30),in Vlan varchar(30)
,in Description_ varchar(30),in IP_Switch varchar(30)
,in User_ varchar(30),in workOrder varchar(30),in Accion_ varchar(30))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`patching` 
(`Building`, `Floor`, `Closet`, `Panel`, 
`Panel_Port`, `Stack`, `Switch`, `Switch_Port`, 
`Interfaz`, `Link`, `Speed`, `Duplex`, 
`Type`, `Vlan`,`Description`, 
`IP_Switch`,`WORK_ORDER`) 
 VALUES ('",Building,"', '",Floor,"', '",Closet,"', '",Panel,"', 
 '",Panel_Port,"', '",Stack,"', '",Switch,"', '",Switch_Port,"', 
 '",Interfaz,"', '",Link,"', '",Speed,"', '",Duplex,"', 
 '",Type_,"', '",Vlan,"', '",Description_,"', 
 '",IP_Switch,"', '",workOrder,"');

");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Action`, `Building`, `Floor`, `Closet`,
 `Panel`, `Panel_Port`, `Stack`, `Switch`,
 `Switch_Port`, `Interfaz`, `Link`, `Speed`,
 `Duplex`, `Type`, `Vlan`, `Description`, 
 `IP_Switch`, `User`,`WORK_ORDER`) 
 VALUES ('",Accion_,"', '",Building,"', '",Floor,"', '",Closet,"',
 '",Panel,"', '",Panel_Port,"', '",Stack,"', '",Switch,"', 
 '",Switch_Port,"', '",Interfaz,"', '",Link,"', '",Speed,"', 
 '",Duplex,"', '",Type_,"', '",Vlan,"', '",Description_,"', 
 '",IP_Switch,"', '",User_,"','",workOrder,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `rellenar_tabla_ip_ipv4` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `rellenar_tabla_ip_ipv4`(in initial_range varchar (40),
in broadcast varchar (40), in id_vlan int(30))
BEGIN
declare in_range varchar(50);
declare fin_range varchar(50);
set in_range = inet_aton(initial_range);
set fin_range = inet_aton(broadcast);

SET @s = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
bucle: LOOP
set in_range = in_range+1;
if in_range = fin_range then
leave bucle;
end if;
SET @s1 = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END LOOP bucle;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `search_vlan_for_Fast_Firewall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `search_vlan_for_Fast_Firewall`(in tabla varchar(30),
in origen varchar(30),in destino varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET_ATON(Initial_Range)and INET_ATON(Final_Range)))
union(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",destino,"') 
BETWEEN INET_ATON(Initial_Range)and INET_ATON(Final_Range))); ");

    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `search_vlan_for_Fast_Firewall_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `search_vlan_for_Fast_Firewall_ipv6`(in tabla varchar(30),
in origen varchar(30),in destino varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET6_NTOA(UNHEX(Initial_Range))and INET6_NTOA(UNHEX(Final_Range))))
union(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",destino,"') 
BETWEEN INET6_NTOA(UNHEX(Initial_Range))and INET6_NTOA(UNHEX(Final_Range)))); ");

    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `search_vlan_for_ip` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `search_vlan_for_ip`(in tabla varchar(30),
in origen varchar(30))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET_ATON('",origen,"') 
BETWEEN INET_ATON(Initial_Range)and INET_ATON(Final_Range)))");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `search_vlan_for_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `search_vlan_for_ipv6`(in tabla varchar(30),
in origen varchar(150))
BEGIN
SET @s = CONCAT("(SELECT * FROM npms.`",tabla,"` where(INET6_NTOA(UNHEX('",origen,"')) 
BETWEEN INET6_NTOA(UNHEX(Initial_Range))and INET6_NTOA(UNHEX(Final_Range))))");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_distinct` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_distinct`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT DISTINCT ",campo," FROM npms.",tabla,";");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` ;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip_desc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_desc`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Action,INET_NTOA(",campo,"),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_like`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
declare campoaton varchar (50);
set campoaton = inet_aton(datocampo);
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", campoaton,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip_like_logs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_like_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
declare campoaton varchar (50);
set campoaton = inet_aton(datocampo);
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", campoaton,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip_like_other_fields` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_like_other_fields`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(IP),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv4_ip_like_other_fields_logs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_like_other_fields_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(IP),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_hostname_all_vlan` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_hostname_all_vlan`(in name_domain varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Vlan,INET6_NTOA(UNHEX(IP)),DNS,Hostname
FROM npms.`domain_name` WHERE  (DNS LIKE '%",name_domain,"%' OR Hostname LIKE '%",name_domain,"%')");
PREPARE stmt FROM @s;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,INET6_NTOA(UNHEX(IP)),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` order by IP desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip_desc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip_desc`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Action,INET6_NTOA(UNHEX(IP)),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip_like`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
declare campoaton varchar (50);
set campoaton = INET6_NTOA(UNHEX(datocampo));
SET @s = CONCAT("SELECT ID,INET6_NTOA(UNHEX(IP)),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", campoaton,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip_like_logs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip_like_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
declare campoaton varchar (50);
set campoaton = INET6_NTOA(UNHEX(datocampo));
SET @s = CONCAT("SELECT ID,INET6_NTOA(UNHEX(IP)),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", campoaton,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip_like_other_fields` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip_like_other_fields`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET6_NTOA(UNHEX(IP)),Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ipv6_ip_like_other_fields_logs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv6_ip_like_other_fields_logs`(in tabla varchar(30),in campo varchar(30),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT ID,INET6_NTOA(UNHEX(IP)),Action,Vlan,Location,Mac,DNS,
Description,Revised_Hostname,Hostname,Date,Work_Order,User
FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_ip_hostname_all_vlan` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ip_hostname_all_vlan`(in name_domain varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`domain_name` 
WHERE  (DNS LIKE '%",name_domain,"%' OR Hostname LIKE '%",name_domain,"%')");
PREPARE stmt FROM @s;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `select_patching` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_patching`(in building varchar(30),in floor varchar(30),
in closet varchar(30),in panel varchar(30),in port_panel varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.patching where Building = '",building,"' and floor = '",floor,"' and closet = '",closet,"' 
and panel = '",panel,"' and Panel_port = '",port_panel,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselectall` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselectall`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselectallorderdesc` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselectallorderdesc`(in tabla varchar(30))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselectwhere` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselectwhere`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where ",campo," = '", datocampo,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselectwhere2fields` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselectwhere2fields`(
in tabla varchar (40),
in campo1 varchar (40),
in campo2 varchar (40),
in datocampo1 varchar(100),
in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` WHERE ",campo1," = '", datocampo1,"' and ",campo2," = '", datocampo2,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselectwherelike` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselectwherelike`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(45))
BEGIN
SET @s = CONCAT("SELECT * FROM npms.`",tabla,"` where ",campo," LIKE '%", datocampo,"%';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simplyselect_view2fields` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simplyselect_view2fields`(
in tabla varchar (40),
in campo1 varchar (40),
in campo2 varchar (40))
BEGIN
SET @s = CONCAT("SELECT  ",campo1,",",campo2," FROM npms.`",tabla,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `simply_delete_where` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `simply_delete_where`(in tabla varchar (40),in campo varchar (40),in datocampo varchar(100))
BEGIN
SET @s = CONCAT("Delete FROM npms.`",tabla,"` where ",campo," = '", datocampo,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `symply_where_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `symply_where_update`(in tabla varchar (40),in campo1 varchar (40),in campo2 varchar(100),
in datocampo1 varchar (40), in datocampo2 varchar(100))
BEGIN
SET @s = CONCAT("UPDATE `npms`.`",tabla,"` SET ",campo1," = '", datocampo1,"' WHERE (`", campo2,"` = '",datocampo2,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `table_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `table_exists`(
in tabla varchar (40))
BEGIN
SET @s = CONCAT("SHOW TABLES LIKE '",tabla,"';");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_inventory_log` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_inventory_log`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN SN varchar(50),IN VarTarea varchar(50))
BEGIN
  SET @s = CONCAT("insert into `log_inventory`
(`HOSTNAME`, `DNS`, `COMMENTS`, `IP`, `SN`, `NAME`, 
`MANUFACTURER`, `LOCATION`, `ENVIRONMENT`, `DOMAIN`, `CONTACT_PROPERTY`, 
`ADITIONAL_INFO`, `PORTS`, `OTHER_1`, `OTHER_2`, `WORK_ORDER`, `USER`) 
select `HOSTNAME`, `DNS`,`COMMENTS`,`IP`,`SN`,`NAME`,
`MANUFACTURER`,`LOCATION`,`ENVIRONMENT`,`DOMAIN`,
`CONTACT_PROPERTY`,`ADITIONAL_INFO`,`PORTS`,`OTHER_1`,`OTHER_2`
,`WORK_ORDER`,`USER`
from `inventory` where SN ='", SN,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`inventory` WHERE SN = '",SN,"';");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_inventory);
UPDATE `npms`.`log_inventory` SET `ACTION` = VarAccion, `WORK_ORDER` = VarTarea, `USER` = VarUsuario WHERE `ID` = @max_id;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_ip_log_ipv4` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_ip_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarIP varchar(30), IN VarVlan varchar(30), IN VarTarea varchar(50))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(VarIP);
  SET @s = CONCAT("insert into `log_ip_ipv4`
(`IP` ,`Vlan`,`Location`,`Mac`,`DNS`,`Description`,`Revised_Hostname`,`Hostname`,`Work_Order`,`User`)
select `IP`, `Vlan`, `Location`,`Mac`,`DNS`,
`Description`,`Revised_Hostname`,`Hostname`,
`Work_Order`,`User`
from `",VarVlan,"` where IP ='", ip_aton,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("UPDATE `npms`.`",VarVlan,"` SET 
 `Location` = '', 
 `Mac` = '', 
 `DNS` = '', 
 `Description` = '', 
 `Revised_Hostname` = '', 
 `Hostname` = '', 
 `Work_Order` = '', 
 `User` = '' WHERE  (`IP` = '",ip_aton,"');
");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_ip_ipv4);
UPDATE `npms`.`log_ip_ipv4` SET `Action` = VarAccion, `Work_Order` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id;    

SET @c = CONCAT("DELETE FROM `npms`.`domain_name` WHERE (`IP` = '",VarIP,"');");
    PREPARE stmt FROM @c;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_ip_log_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_ip_log_ipv6`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarIP varchar(30), IN VarVlan varchar(30), IN VarTarea varchar(50))
BEGIN
  SET @s = CONCAT("insert into `log_ip_ipv6`
(`IP` ,`Vlan`,`Location`,`Mac`,`DNS`,`Description`,`Revised_Hostname`,`Hostname`,`Work_Order`,`User`)
select `IP`, `Vlan`, `Location`,`Mac`,`DNS`,
`Description`,`Revised_Hostname`,`Hostname`,
`Work_Order`,`User`
from `",VarVlan,"` where IP ='", VarIP,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("DELETE FROM `npms`.`",VarVlan,"` WHERE `IP` = '", VarIP,"';");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_ip_ipv6);
UPDATE `npms`.`log_ip_ipv6` SET `Action` = VarAccion, `Work_Order` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id;  
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_vlan_log_ipv4` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_vlan_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) , IN VarVlan varchar(20) , IN VarTarea varchar(50))
BEGIN

insert into log_vlan_ipv4 (`Vlan` ,`Name`,`Location`,`Vsys/balancer/other`,`Description`,`Network`,
`Initial_Range`,`Final_Range`,`Mask`,`Gateway`,`Observations`,`Device`,
`Firewall`,`Environment`,`Normative`,`Status`,`Network_Type`,`Equipment` ,`Classification`,`Work_Order`,`User`)
select `Vlan`, `Name`, `Location`,`Vsys/balancer/other`,`Description`,`Network`,
`Initial_Range`,`Final_Range`,`Mask`,`Gateway`,`Observations`,
`Device`,`Firewall`,`Environment`,`Normative`,`Status`,`Network_Type`,`Equipment`,
`Classification`,`Work_Order`,`User`
from vlan_ipv4
where Vlan = VarVlan;
SET @max_id = (SELECT MAX(ID) FROM log_vlan_ipv4);
UPDATE `npms`.`log_vlan_ipv4` SET `Action` = VarAccion, `Work_Order` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id; 
DELETE FROM `npms`.vlan_ipv4 WHERE (`Vlan` = VarVlan);
 SET @s = CONCAT("DROP TABLE IF EXISTS `",VarVlan,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `update_vlan_log_ipv6` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_vlan_log_ipv6`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) , IN VarVlan Int,IN Tabla_con_Prefijo varchar(20),IN VarTarea varchar(50))
BEGIN

insert into log_vlan_ipv6 (`Vlan` ,`Name`,`Location`,`Vsys/balancer/other`,`Description`,`Network`,
`Initial_Range`,`Final_Range`,`Mask`,`Gateway`,`Observations`,`Device`,
`Firewall`,`Environment`,`Normative`,`Status`,`Network_Type`,`Equipment` ,`Classification`,`Work_Order`,`User`)
select `Vlan`, `Name`, `Location`,`Vsys/balancer/other`,`Description`,`Network`,
`Initial_Range`,`Final_Range`,`Mask`,`Gateway`,`Observations`,
`Device`,`Firewall`,`Environment`,`Normative`,`Status`,`Network_Type`,`Equipment`,
`Classification`,`Work_Order`,`User`
from vlan_ipv6
where Vlan = VarVlan;
SET @max_id = (SELECT MAX(ID) FROM log_vlan_ipv6);
UPDATE `npms`.`log_vlan_ipv6` SET `Action` = VarAccion, `Work_Order` = VarTarea, `User` = VarUsuario WHERE `ID` = @max_id; 
DELETE FROM `npms`.vlan_ipv6 WHERE (`Vlan` = VarVlan);
SET @s = CONCAT("DROP TABLE IF EXISTS `",Tabla_con_Prefijo,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-21 18:28:06
