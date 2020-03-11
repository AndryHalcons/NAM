DELIMITER $$
CREATE PROCEDURE `update_vlan_log_ipv6`(IN VarAccion Varchar(20), 
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
END$$
DELIMITER ;
