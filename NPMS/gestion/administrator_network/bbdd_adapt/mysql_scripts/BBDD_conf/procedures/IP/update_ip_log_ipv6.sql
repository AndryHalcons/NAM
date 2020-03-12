DELIMITER $$
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
END$$
DELIMITER ;
