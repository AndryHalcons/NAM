DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_ipv4_ip_desc`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,Accion,INET_NTOA(",campo,"),Vlan,Ubicacion,Mac,DNS,
Descripcion,Hostname_revisado,Hostname,Fecha_modificacion,Tarea,usuario
FROM npms.`",tabla,"` ORDER BY ID desc;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
