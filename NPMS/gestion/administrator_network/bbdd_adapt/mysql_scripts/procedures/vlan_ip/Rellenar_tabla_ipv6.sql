DELIMITER $$
CREATE  PROCEDURE `rellenar_tabla_ip_ipv6`(in initial_range varchar (150),
in finis_range varchar (150), in id_vlan int(50),in formateo_vlan varchar(50))
BEGIN
declare in_range varchar(150);
declare fin_range varchar(150);
set in_range = HEX(INET6_ATON(initial_range));
set fin_range = HEX(INET6_ATON(finis_range));

SET @s = CONCAT("INSERT INTO `npms`.`",formateo_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
bucle: LOOP
set in_range = in_range+1;
if in_range = fin_range then
leave bucle;
end if;
SET @s1 = CONCAT("INSERT INTO `npms`.`",formateo_vlan,"` (`IP`, `Vlan`) VALUES ('",in_range,"', '",id_vlan,"');");
    PREPARE stmt FROM @s1;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt; 
END LOOP bucle;
END$$
DELIMITER ;