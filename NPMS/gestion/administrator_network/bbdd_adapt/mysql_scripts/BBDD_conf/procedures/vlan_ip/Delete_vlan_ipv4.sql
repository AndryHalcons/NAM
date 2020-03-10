DELIMITER $$
CREATE PROCEDURE `update_vlan_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) , IN VarVlan varchar(20) , IN VarTarea varchar(50))
BEGIN

insert into log_vlan_ipv4 (`Vlan` ,`Nombre`,`Ubicacion`,`Vsys/balanceador/otro`,`Descripcion`,`Direccion_red`,
`Rango_ip_inicio`,`Rango_ip_fin`,`Mascara`,`Gateway`,`Observaciones`,`Dispositivo`,
`Firewall`,`Entorno`,`Normativa`,`Estado`,`Tipo_de_red`,`Equipos` ,`Clasificacion`,`Tarea`,`Usuario`)
select `Vlan`, `Nombre`, `Ubicacion`,`Vsys/balanceador/otro`,`Descripcion`,`Direccion_red`,
`Rango_ip_inicio`,`Rango_ip_fin`,`Mascara`,`Gateway`,`Observaciones`,
`Dispositivo`,`Firewall`,`Entorno`,`Normativa`,`Estado`,`Tipo_de_red`,`Equipos`,
`Clasificacion`,`Tarea`,`Usuario`
from vlan_ipv4
where Vlan = VarVlan;
SET @max_id = (SELECT MAX(ID) FROM log_vlan_ipv4);
UPDATE `npms`.`log_vlan_ipv4` SET `Accion` = VarAccion, `Tarea` = VarTarea, `Usuario` = VarUsuario WHERE `ID` = @max_id; 
DELETE FROM `npms`.vlan_ipv4 WHERE (`Vlan` = VarVlan);
 SET @s = CONCAT("DROP TABLE IF EXISTS `",VarVlan,"`;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;
