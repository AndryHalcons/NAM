DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `rellenar_tabla_ip_ipv4`(in initial_range varchar (40),
in broadcast varchar (40), in id_vlan int(30))
BEGIN
declare in_range varchar(50);
declare fin_range varchar(50);
set in_range = inet_aton(initial_range);
set fin_range = inet_aton(broadcast);

SET @s = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
bucle: LOOP
set in_range = in_range+1;
if in_range = fin_range then
leave bucle;
end if;
SET @s1 = CONCAT("INSERT INTO `npms`.`",id_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END LOOP bucle;
END$$
DELIMITER ;
