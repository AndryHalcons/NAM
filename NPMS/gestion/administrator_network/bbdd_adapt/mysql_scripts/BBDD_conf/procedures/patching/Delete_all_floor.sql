/*********************Procedure que borra Floor (planta) entero en patching (floor delete)(parcheo)***************************/
DELIMITER $$
CREATE PROCEDURE `delete_all_floor`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN Building varchar(50),IN VarTarea varchar(50),IN Floor varchar(50))
BEGIN
  SET @s = CONCAT("INSERT INTO `npms`.`log_patching` 
(`Accion`, `Building`, `Floor`, `Closet`,
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
END$$
DELIMITER ;


