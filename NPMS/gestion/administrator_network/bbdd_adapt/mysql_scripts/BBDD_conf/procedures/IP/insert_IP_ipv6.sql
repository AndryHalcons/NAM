DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_ip_ipv6`(in id_accion varchar(80),
in id_vlan varchar(80),in id_ip varchar(80),in id_Ubicacion varchar(80),in id_mac varchar(100),
in id_dns varchar(80),in id_Descripcion varchar(80),in id_hostnameR varchar(80),
in id_hostname varchar(80),in id_Tarea varchar(80),in id_usuario varchar(80),in id_FormateoTabla varchar(80))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`",id_FormateoTabla,"` (`Vlan`, `IP`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
VALUES ('",id_vlan,"', '",id_ip,"','",id_Ubicacion,"', '",id_mac,"','",id_dns,"','",id_Descripcion,"', 
'",id_hostnameR,"', '",id_hostname,"', '",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
SET @b = CONCAT("INSERT INTO `npms`.`log_ip_ipv6` 
(`IP`, `Action`, `Vlan`, `Location`, `Mac`, `DNS`, `Description`, `Revised_Hostname`, `Hostname`, `Work_Order`, `User`) 
VALUES ('",id_ip,"', '",id_accion,"', '",id_vlan,"','",id_Ubicacion,"',
'",id_mac,"', '",id_dns,"', '",id_Descripcion,"', '",id_hostnameR,"', '",id_hostname,"', 
'",id_Tarea,"', '",id_usuario,"');
");
    PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END$$
DELIMITER ;
