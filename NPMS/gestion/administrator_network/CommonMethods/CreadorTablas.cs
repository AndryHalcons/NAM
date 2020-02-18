using NetTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    class CreadorTablas
    {

        //CREACION DE LA NUEVA TABLA IPV6
        public static void CreartablaIPv6(string id_DireccionRed, string id_vlan, string Gateway1, string Gateway2, string Gateway3, string RangoInicio, string RangoFin)
        {
            //Creacion de la tabla de red
            string query0 = "CREATE TABLE `npms`.`ipv6_" + id_vlan + "` (`ID` INT NOT NULL AUTO_INCREMENT,`Vlan` INT NOT NULL,`IP` VARCHAR(30) NOT NULL,`Ubicacion` VARCHAR(150) NULL,`Mac` VARCHAR(30) NULL,`DNS` VARCHAR(150) NULL,`Descripcion` VARCHAR(150) NULL,`Hostname_revisado` VARCHAR(150) NULL,`Hostname` VARCHAR(150) NULL,`Fecha_modificacion` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  ON UPDATE CURRENT_TIMESTAMP,`Tarea` VARCHAR(150) NULL,`usuario` VARCHAR(150) NULL,PRIMARY KEY (`ID`,`IP`),UNIQUE INDEX `IP_UNIQUE` (`IP` ASC) VISIBLE);";
            Sentencias.Bbdd_apply(id_vlan, query0);
            //Inserción de la primera y ultima ip del rango en la tabla
            string query1 = "INSERT INTO `npms`.`ipv6_" + id_vlan + "` (`Vlan`, `IP`) VALUES ('" + id_vlan + "', '" + RangoInicio + "');";
            Sentencias.Bbdd_apply(id_vlan, query1);
            string query2 = "INSERT INTO `npms`.`ipv6_" + id_vlan + "` (`Vlan`, `IP`) VALUES ('" + id_vlan + "', '" + RangoFin + "');";
            Sentencias.Bbdd_apply(id_vlan, query2);
            //INSERTA en la tabla los Gateways
            //Inserccion del Gateway1 (obligatorio)
            string query3 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway1', `Hostname` = 'Gateway1' WHERE  (`IP` = '" + Gateway1 + "');";
            Sentencias.Bbdd_apply(id_vlan, query3);
            //Comprueba que Gateway2 y Gateway3 tienen algún valor, si lo tienen los inserta.
            bool valor_gateway2 = Common.ValidadorCamposVacios_SinMensaje(Gateway2);
            if (valor_gateway2 == true)
            {
                string query4 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway2', `Hostname` = 'Gateway2' WHERE  (`IP` = '" + Gateway2 + "');";
                Sentencias.Bbdd_apply(id_vlan, query4);
            }
            bool valor_gateway3 = Common.ValidadorCamposVacios_SinMensaje(Gateway3);
            if (valor_gateway3 == true)
            {
                string query5 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway3', `Hostname` = 'Gateway3' WHERE  (`IP` = '" + Gateway3 + "');";
                Sentencias.Bbdd_apply(id_vlan, query5);
            }
        }

    }
}
