DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ip_ipv4`(in id_accion varchar(30),
in id_vlan varchar(30),in id_ip varchar(30),in id_Ubicacion varchar(30),in id_mac varchar(30),
in id_dns varchar(30),in id_Descripcion varchar(30),in id_hostnameR varchar(30),
in id_hostname varchar(30),in id_Tarea varchar(30),in id_usuario varchar(30))
BEGIN
declare ip_aton varchar(50);
set ip_aton = inet_aton(id_ip);
SET @s = CONCAT("UPDATE `npms`.`",id_vlan,"` SET 
`Ubicacion` = '",id_Ubicacion,"', 
`Mac` = '",id_mac,"', 
`DNS` = '",id_dns,"', 
`Descripcion` = '",id_Descripcion,"', 
`Hostname_revisado` = '",id_hostnameR,"', 
`Hostname` = '",id_hostname,"', 
`Tarea` = '",id_Tarea,"', 
`usuario` = '",id_usuario,"' 
WHERE (`IP` = '",ip_aton,"');

");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_ip_ipv4` 
(`IP`, `Accion`, `Vlan`, `Ubicacion`, `Mac`, `DNS`, `Descripcion`, `Hostname_revisado`, `Hostname`, `Tarea`, `usuario`) 
VALUES ('",ip_aton,"', '",id_accion,"', '",id_vlan,"','",id_Ubicacion,"',
'",id_mac,"', '",id_dns,"', '",id_Descripcion,"', '",id_hostnameR,"', '",id_hostname,"', 
'",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;
