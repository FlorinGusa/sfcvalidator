﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scraper
{
    public class Constants
    {
     

        static Dictionary<string, List<string>> _constants = new Dictionary<string, List<string>>(){
            { "contactPageRef" , new List<string>(){ "contact", "legal-notice" } },
            { "emailRef" , new List<string>(){ "mailto:", "email"} },
        };

        Tuple<string, string>[] _urls =
         {
            new Tuple<string,string>("[Account]","https://www.rte.pt/home"),
            new Tuple<string,string>("[Account]","https://www.gpelettronicasrl.com/"),
            new Tuple<string,string>("[Account]","https://www.szmk-nk.com/"),
            new Tuple<string,string>("[Account]","https://www.techniplast.pl/pl/"),
            new Tuple<string,string>("[Account]","www.sidasa.com"),
            new Tuple<string,string>("[Account]","www.d.hellich-werkzeuge.de"),
            new Tuple<string,string>("[Account]","www.arvato-supply-chain.com"),
            new Tuple<string,string>("[Account]","www.servitech-industrieautomation.ch"),
            new Tuple<string,string>("[Account]","http://www.dmp-kovinarstvo.si/"),
            new Tuple<string,string>("[Account]","https://www.2-g.com/de"),
            new Tuple<string,string>("[Account]","www.jelinek-mdt.cz"),
            new Tuple<string,string>("[Account]","https://kaik.kz"),
            new Tuple<string,string>("[Account]","https://suman.ba/bs"),
            new Tuple<string,string>("[Account]","http://www.atlas-contacte.de"),
            new Tuple<string,string>("[Account]","www.fecupral.sk"),
            new Tuple<string,string>("[Account]","www.bayzoltan.hu"),
            new Tuple<string,string>("[Account]","https://www.cretafarms.gr/"),
            new Tuple<string,string>("[Account]","www.mivasoft.sk"),
            new Tuple<string,string>("[Account]","https://www.alnapress.be"),
            new Tuple<string,string>("[Account]","www.systron-gmbh.ch"),
            new Tuple<string,string>("[Account]","www.uni-miskolc.hu"),
            new Tuple<string,string>("[Account]","https://www.unilininsulation.com"),
            new Tuple<string,string>("[Account]","https://www.kolliasdoors.com"),
            new Tuple<string,string>("[Account]","https://www.ent-en.com/en/about/info"),
            new Tuple<string,string>("[Account]","www.wp-kemper.de"),
            new Tuple<string,string>("[Account]","www.piaservice.nl"),
            new Tuple<string,string>("[Account]","https://www.univ-ubs.fr/fr/index.html"),
            new Tuple<string,string>("[Account]","https://www.tactotek.com/"),
            new Tuple<string,string>("[Account]","www.karlville.com"),
            new Tuple<string,string>("[Account]","https://www.rizz.design/"),
            new Tuple<string,string>("[Account]","https://www.lessmann.com/"),
            new Tuple<string,string>("[Account]","https://webbwheel.com/oem_trailer_contact.php"),
            new Tuple<string,string>("[Account]","https://awesome-technologies.de/"),
            new Tuple<string,string>("[Account]","www.vetter-band.de"),
            new Tuple<string,string>("[Account]","https://www.soft-in.com/"),
            new Tuple<string,string>("[Account]","www.masterplast.si"),
            new Tuple<string,string>("[Account]","www.swissfactory.group"),
            new Tuple<string,string>("[Account]","https://www.zsw-bw.de/"),
            new Tuple<string,string>("[Account]","www.viroteq.ai"),
            new Tuple<string,string>("[Account]","www.foodtech-bv.nl"),
            new Tuple<string,string>("[Account]","https://www.casamas.com/"),
            new Tuple<string,string>("[Account]","https://agz.ch"),
            new Tuple<string,string>("[Account]","https://www.alfatube.com/"),
            new Tuple<string,string>("[Account]","www.liget.cz"),
            new Tuple<string,string>("[Account]","www.robot-art.de"),
            new Tuple<string,string>("[Account]","https://polymerge.de/"),
            new Tuple<string,string>("[Account]","www.gumbase.com"),
            new Tuple<string,string>("[Account]","www.schwamborn-sondermaschinen.de/"),
            new Tuple<string,string>("[Account]","www.vincorion.com"),
            new Tuple<string,string>("[Account]","www.apivita.com"),
            new Tuple<string,string>("[Account]","https://www.tbduk.co.uk/"),
            new Tuple<string,string>("[Account]","http://holztechnik-zimmermann.de/"),
            new Tuple<string,string>("[Account]","www.hm-elektro.de"),
            new Tuple<string,string>("[Account]","https://dreiturm.de/impressum/"),
            new Tuple<string,string>("[Account]","www.nemak.com"),
            new Tuple<string,string>("[Account]","www.roesler-automaten.de"),
            new Tuple<string,string>("[Account]","https://www.mehano.si/en"),
            new Tuple<string,string>("[Account]","https://www.bentrias.de/impressum/"),
            new Tuple<string,string>("[Account]","https://www.eco-remarketing.de/impressum/"),
            new Tuple<string,string>("[Account]","www.moellergroup.com"),
            new Tuple<string,string>("[Account]","www.temaxel.es"),
            new Tuple<string,string>("[Account]","www.rebedex.nl"),
            new Tuple<string,string>("[Account]","swiftdental.co.uk"),
            new Tuple<string,string>("[Account]","https://www.hemo.ch/"),
            new Tuple<string,string>("[Account]","www.roechling.com/oepping"),
            new Tuple<string,string>("[Account]","www.vkm.co.at"),
            new Tuple<string,string>("[Account]","www.rsg-automation.de"),
            new Tuple<string,string>("[Account]","http://www.innalabs.com/"),
            new Tuple<string,string>("[Account]","http://potensperforacija.co.rs/index.php/sr/"),
            new Tuple<string,string>("[Account]","www.euchner.nl"),
            new Tuple<string,string>("[Account]","www.ra-st.si"),
            new Tuple<string,string>("[Account]","www.karupoegpuhh.ee"),
            new Tuple<string,string>("[Account]","www.vahle.de"),
            new Tuple<string,string>("[Account]","https://flexshop.hu/"),
            new Tuple<string,string>("[Account]","https://www.elcompanies.com/en"),
            new Tuple<string,string>("[Account]","magna.com"),
            new Tuple<string,string>("[Account]","https://lemariepatissier.com/"),
            new Tuple<string,string>("[Account]","www.emslaender.de"),
            new Tuple<string,string>("[Account]","www.fdmethcon.de"),
            new Tuple<string,string>("[Account]","https://sixt-wzm.de"),
            new Tuple<string,string>("[Account]","https://www.cellwar.com"),
            new Tuple<string,string>("[Account]","http://www.agricorn.hu/"),
            new Tuple<string,string>("[Account]","www.invent-tec.at"),
            new Tuple<string,string>("[Account]","http://www.mtm-metalltechnik.de"),
            new Tuple<string,string>("[Account]","www.wec-machining.com"),
            new Tuple<string,string>("[Account]","www.joint-it.com"),
            new Tuple<string,string>("[Account]","www.granit-parts.com"),
            new Tuple<string,string>("[Account]","https://coolinfinity.kz"),
            new Tuple<string,string>("[Account]","www.l3bm.com"),
            new Tuple<string,string>("[Account]","www.com-inject.com"),
            new Tuple<string,string>("[Account]","http://inst-tech.ru/"),
            new Tuple<string,string>("[Account]","www.pentagonplastics.co.uk"),
            new Tuple<string,string>("[Account]","www.hamiltoncompany.com"),
            new Tuple<string,string>("[Account]","wisetc.co.il"),
            new Tuple<string,string>("[Account]","https://demcon-industrial.com/"),
            new Tuple<string,string>("[Account]","https://www.gestalt-robotics.com/"),
            new Tuple<string,string>("[Account]","www.kalant.ch"),
            new Tuple<string,string>("[Account]","https://www.th-rosenheim.de/impressum/"),
            new Tuple<string,string>("[Account]","www.honeywell.com"),
            new Tuple<string,string>("[Account]","https://www.schell.eu"),
            new Tuple<string,string>("[Account]","https://www.telegaertner.com"),
            new Tuple<string,string>("[Account]","https://retriver.hr/en/naslovnica/"),
            new Tuple<string,string>("[Account]","www.mi-3.co.uk"),
            new Tuple<string,string>("[Account]","www.herz-gmbh.com"),
            new Tuple<string,string>("[Account]","http://prominkom.ru/"),
            new Tuple<string,string>("[Account]","http://www.solystic.com"),
            new Tuple<string,string>("[Account]","https://acceliox.io/"),
            new Tuple<string,string>("[Account]","www.schuessler-welding.de"),
            new Tuple<string,string>("[Account]","https://masine-za-brizganje.rs/"),
            new Tuple<string,string>("[Account]","www.sr-schweisstechnik.de"),
            new Tuple<string,string>("[Account]","www.scam-marine.hr"),
            new Tuple<string,string>("[Account]","www.teckentrup.biz"),
            new Tuple<string,string>("[Account]","http://macconceptbois.fr/"),
            new Tuple<string,string>("[Account]","https://www.anmak58.com/"),
            new Tuple<string,string>("[Account]","https://radogost-mash.ru/"),
            new Tuple<string,string>("[Account]","http://www.liquidea.nl/"),
            new Tuple<string,string>("[Account]","www.holderhof.ch"),
            new Tuple<string,string>("[Account]","www.possehlelectronic.de"),
            new Tuple<string,string>("[Account]","www.Proca.st"),
            new Tuple<string,string>("[Account]","https://biofilter.hu/"),
            new Tuple<string,string>("[Account]","www.marostech.eu"),
            new Tuple<string,string>("[Account]","https://www.raumedic.com/"),
            new Tuple<string,string>("[Account]","https://bakalland.pl/"),
            new Tuple<string,string>("[Account]","www.hofor.hu"),
            new Tuple<string,string>("[Account]","www.arteliagroup.com"),
            new Tuple<string,string>("[Account]","https://agrocontrol.nl/en/home-en/"),
            new Tuple<string,string>("[Account]","www.foxbot.ch"),
            new Tuple<string,string>("[Account]","https://www.krikri.gr/homeen/"),
            new Tuple<string,string>("[Account]","www.divardy.nl"),
            new Tuple<string,string>("[Account]","https://www.peds.li/"),
            new Tuple<string,string>("[Account]","www.maschinenbau-bender.de"),
            new Tuple<string,string>("[Account]","www.miba.com"),
            new Tuple<string,string>("[Account]","https://www.nozominetworks.com/"),
            new Tuple<string,string>("[Account]","http://www.mk-kubitza.com/"),
            new Tuple<string,string>("[Account]","www.circuli-ion.com"),
            new Tuple<string,string>("[Account]","www.bertold.pl"),
            new Tuple<string,string>("[Account]","https://megadis.gr/en/company/"),
            new Tuple<string,string>("[Account]","www.alpenta.com"),
            new Tuple<string,string>("[Account]","https://zs3jaslo.pl/"),
            new Tuple<string,string>("[Account]","www.saespa.com"),
            new Tuple<string,string>("[Account]","www.littlemoons.com"),
            new Tuple<string,string>("[Account]","www.rocvf.nl"),
            new Tuple<string,string>("[Account]","www.morotreviso.com"),
            new Tuple<string,string>("[Account]","http://kamilka.uz/"),
            new Tuple<string,string>("[Account]","www.checktec.de"),
            new Tuple<string,string>("[Account]","https://www.hs-tumbler.com/"),
            new Tuple<string,string>("[Account]","www.alpo-med.de"),
            new Tuple<string,string>("[Account]","www.efiautomotive.com"),
            new Tuple<string,string>("[Account]","https://www.karupoegpuhh.ee/"),
            new Tuple<string,string>("[Account]","http://elektrokrucso.hu/") 
        };
    }
}