DELIMITER $$
CREATE PROCEDURE `update_vlan_log_ipv4`(IN VarAccion Varchar(20), 
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
END$$
DELIMITER ;
