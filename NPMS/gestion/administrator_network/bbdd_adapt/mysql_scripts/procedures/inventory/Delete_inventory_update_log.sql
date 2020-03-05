/*********************Procedure update inventory***************************/


DELIMITER $$
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
END$$
DELIMITER ;

