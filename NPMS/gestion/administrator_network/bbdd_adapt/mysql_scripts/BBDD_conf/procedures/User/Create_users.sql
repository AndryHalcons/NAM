DELIMITER $$
CREATE PROCEDURE `create_user`(in usuario varchar (40),
in pass varchar (40),in rol varchar(100),
in for_user varchar(40))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`usuarios` (`User`, `Password`, `Rol`) 
VALUES ('",usuario,"', '",pass,"', '",rol,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
    
set @b = CONCAT("INSERT INTO `npms`.`log_user` 
(`Action`, `User`, `Rol`, `For_User`) 
VALUES ('Create', '",usuario,"', '",rol,"', '",for_user,"');");
PREPARE stmt FROM @b;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;
