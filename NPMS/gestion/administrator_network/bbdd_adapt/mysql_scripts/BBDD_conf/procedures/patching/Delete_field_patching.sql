/*********************Procedure que borra field (fila) patching (parcheo)***************************/

DELIMITER $$
CREATE PROCEDURE `delete_field_patching`(IN VarAccion Varchar(20), 
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
END$$
DELIMITER ;
