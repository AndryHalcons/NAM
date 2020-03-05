DELIMITER $$
CREATE PROCEDURE `update_ip_log_ipv4`(IN VarAccion Varchar(20), 
IN VarUsuario varchar(20) ,IN VarIP varchar(30), IN VarVlan varchar(30), IN VarTarea varchar(50))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(VarIP);
  SET @s = CONCAT("insert into `log_ip_ipv4`
(`IP` ,`Vlan`,`Ubicacion`,`Mac`,`DNS`,`Descripcion`,`Hostname_revisado`,`Hostname`,`tarea`,`usuario`)
select `IP`, `Vlan`, `Ubicacion`,`Mac`,`DNS`,
`Descripcion`,`Hostname_revisado`,`Hostname`,
`tarea`,`usuario`
from `",VarVlan,"` where IP ='", ip_aton,"'");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
 SET @s2 = CONCAT("UPDATE `npms`.`",VarVlan,"` SET 
 `Ubicacion` = '', 
 `Mac` = '', 
 `DNS` = '', 
 `Descripcion` = '', 
 `Hostname_revisado` = '', 
 `Hostname` = '', 
 `Tarea` = '', 
 `usuario` = '' WHERE  (`IP` = '",ip_aton,"');
");
    PREPARE stmt FROM @s2;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
SET @max_id = (SELECT MAX(ID) FROM log_ip_ipv4);
UPDATE `npms`.`log_ip_ipv4` SET `Accion` = VarAccion, `Tarea` = VarTarea, `Usuario` = VarUsuario WHERE `ID` = @max_id;    
END$$
DELIMITER ;
