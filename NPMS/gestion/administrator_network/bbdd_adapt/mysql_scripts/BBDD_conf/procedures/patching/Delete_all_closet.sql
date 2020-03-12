/*********************Procedure que borra Closet (Armario) entero en patching (floor delete)(parcheo)***************************/


DELIMITER $$
CREATE PROCEDURE `delete_all_closet`(IN VarAccion Varchar(20), 
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
END$$
DELIMITER ;