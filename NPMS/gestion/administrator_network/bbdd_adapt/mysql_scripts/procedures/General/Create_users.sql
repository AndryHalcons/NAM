/*********************Procedure que crea usuarios***************************/

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `create_user`(in usuario varchar (40),in pass varchar (40),in rol varchar(100))
BEGIN
SET @s = CONCAT("INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) 
VALUES ('",usuario,"', '",pass,"', '",rol,"');");
    PREPARE stmt FROM @s;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;   
END$$
DELIMITER ;

