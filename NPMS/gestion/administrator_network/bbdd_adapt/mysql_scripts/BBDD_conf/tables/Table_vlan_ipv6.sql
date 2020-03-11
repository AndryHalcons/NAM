/* --------------Creacion vlan_ipv6 --------------- */


  CREATE TABLE `npms`.`vlan_ipv6` (
  `Vlan` INT NOT NULL,
  `Name` VARCHAR(150) NULL,
  `Location` VARCHAR(150) NULL,
  `Vsys/balancer/other` VARCHAR(150) NULL,
  `Description` VARCHAR(150) NULL,
  `Network` VARCHAR(65) NOT NULL,
  `Initial_Range` VARCHAR(65) NULL,
  `Final_Range` VARCHAR(65) NULL,
  `Mask` VARCHAR(65) NULL,
  `Gateway` VARCHAR(65) NULL,
  `Observations` VARCHAR(200) NULL,
  `Device` VARCHAR(150) NULL,
  `Firewall` VARCHAR(150) NULL,
  `Environment` VARCHAR(150) NULL,
  `Normative` VARCHAR(150) NULL,
  `Status` VARCHAR(150) NULL,
  `Network_Type` VARCHAR(150) NULL,
  `Equipment` VARCHAR(150) NULL,
  `Classification` VARCHAR(150) NULL,
  `Work_Order` VARCHAR(150) NULL,
  `User` VARCHAR(150) NULL,
  `Date` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
  ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Vlan`, `Network`),
  UNIQUE INDEX `Vlan_UNIQUE` (`Vlan` ASC) VISIBLE,
  UNIQUE INDEX `Network_UNIQUE` (`Network` ASC) VISIBLE);