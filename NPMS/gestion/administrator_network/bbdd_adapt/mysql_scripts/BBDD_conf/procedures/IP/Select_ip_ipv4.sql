DELIMITER $$
CREATE  PROCEDURE `select_ipv4_ip`(in tabla varchar(30),in campo varchar(30))
BEGIN
SET @s = CONCAT("SELECT ID,INET_NTOA(",campo,"),Vlan,Ubicacion,Mac,DNS,
Descripcion,Hostname_revisado,Hostname,Fecha_modificacion,Tarea,usuario
FROM npms.`",tabla,"` ;");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
