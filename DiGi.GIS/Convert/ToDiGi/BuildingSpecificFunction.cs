﻿using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static BuildingSpecificFunction ToDiGi(this OT_FunSzczegolowaBudynku oT_FunSzczegolowaBudynku)
        {
            return oT_FunSzczegolowaBudynku switch
            {
                OT_FunSzczegolowaBudynku.apteka => BuildingSpecificFunction.pharmacy,
                OT_FunSzczegolowaBudynku.archiwum => BuildingSpecificFunction.archive,
                OT_FunSzczegolowaBudynku.areszt_sledczy => BuildingSpecificFunction.remand_prison,
                OT_FunSzczegolowaBudynku.bacowka => BuildingSpecificFunction.shepherds_hut,
                OT_FunSzczegolowaBudynku.bank => BuildingSpecificFunction.bank,
                OT_FunSzczegolowaBudynku.basen_kapielowy => BuildingSpecificFunction.swimming_pool,
                OT_FunSzczegolowaBudynku.biblioteka => BuildingSpecificFunction.library,
                OT_FunSzczegolowaBudynku.budynek_gospodarczy => BuildingSpecificFunction.utility_building,
                OT_FunSzczegolowaBudynku.budynek_jednorodzinny => BuildingSpecificFunction.single_family_building,
                OT_FunSzczegolowaBudynku.budynek_kontroli_ruchu_kolejowego => BuildingSpecificFunction.railway_traffic_control_building,
                OT_FunSzczegolowaBudynku.budynek_kontroli_ruchu_powietrznego => BuildingSpecificFunction.air_traffic_control_building,
                OT_FunSzczegolowaBudynku.budynek_ogrodu_zoologicznego_lub_botanicznego => BuildingSpecificFunction.zoo_or_botanical_garden_building,
                OT_FunSzczegolowaBudynku.budynek_produkcyjny_zwierzat_hodowlanych => BuildingSpecificFunction.livestock_production_building,
                OT_FunSzczegolowaBudynku.budynek_spedycji => BuildingSpecificFunction.shipping_building,
                OT_FunSzczegolowaBudynku.budynek_wielorodzinny => BuildingSpecificFunction.multi_family_building,
                OT_FunSzczegolowaBudynku.budynki_cmentarne => BuildingSpecificFunction.cemetery_buildings,
                OT_FunSzczegolowaBudynku.centrum_handlowe => BuildingSpecificFunction.shopping_center,
                OT_FunSzczegolowaBudynku.centrum_informacyjne => BuildingSpecificFunction.information_center,
                OT_FunSzczegolowaBudynku.centrum_konferencyjne => BuildingSpecificFunction.conference_center,
                OT_FunSzczegolowaBudynku.centrum_telekomunikacyjne => BuildingSpecificFunction.telecommunications_center,
                OT_FunSzczegolowaBudynku.cerkiew => BuildingSpecificFunction.church,
                OT_FunSzczegolowaBudynku.chlodnia => BuildingSpecificFunction.cold_storage,
                OT_FunSzczegolowaBudynku.dom_dla_bezdomnych => BuildingSpecificFunction.homeless_shelter,
                OT_FunSzczegolowaBudynku.dom_dziecka => BuildingSpecificFunction.childrens_home,
                OT_FunSzczegolowaBudynku.dom_kultury => BuildingSpecificFunction.cultural_center,
                OT_FunSzczegolowaBudynku.dom_letniskowy => BuildingSpecificFunction.summer_house,
                OT_FunSzczegolowaBudynku.dom_opieki_spolecznej => BuildingSpecificFunction.social_care_home,
                OT_FunSzczegolowaBudynku.dom_parafialny => BuildingSpecificFunction.parish_house,
                OT_FunSzczegolowaBudynku.dom_pogrzebowy => BuildingSpecificFunction.funeral_home,
                OT_FunSzczegolowaBudynku.dom_rekolekcyjny => BuildingSpecificFunction.retreat_house,
                OT_FunSzczegolowaBudynku.dom_studencki => BuildingSpecificFunction.student_dormitory,
                OT_FunSzczegolowaBudynku.dom_towarowy_lub_handlowy => BuildingSpecificFunction.department_store,
                OT_FunSzczegolowaBudynku.dom_weselny => BuildingSpecificFunction.wedding_house,
                OT_FunSzczegolowaBudynku.dom_wypoczynkowy => BuildingSpecificFunction.holiday_house,
                OT_FunSzczegolowaBudynku.dom_zakonny => BuildingSpecificFunction.monastery_house,
                OT_FunSzczegolowaBudynku.domek_kempingowy => BuildingSpecificFunction.camping_cabin,
                OT_FunSzczegolowaBudynku.dworzec_autobusowy => BuildingSpecificFunction.bus_station,
                OT_FunSzczegolowaBudynku.dworzec_kolejowy => BuildingSpecificFunction.train_station,
                OT_FunSzczegolowaBudynku.dworzec_lotniczy => BuildingSpecificFunction.airport_terminal,
                OT_FunSzczegolowaBudynku.dzwonnica => BuildingSpecificFunction.bell_tower,
                OT_FunSzczegolowaBudynku.elektrocieplownia => BuildingSpecificFunction.combined_heat_power_plant,
                OT_FunSzczegolowaBudynku.elektrownia => BuildingSpecificFunction.power_plant,
                OT_FunSzczegolowaBudynku.elewator => BuildingSpecificFunction.grain_elevator,
                OT_FunSzczegolowaBudynku.filharmonia => BuildingSpecificFunction.philharmonic_hall,
                OT_FunSzczegolowaBudynku.galeria_sztuki => BuildingSpecificFunction.art_gallery,
                OT_FunSzczegolowaBudynku.garaz => BuildingSpecificFunction.garage,
                OT_FunSzczegolowaBudynku.hala_sportowa => BuildingSpecificFunction.sports_hall,
                OT_FunSzczegolowaBudynku.hala_targowa => BuildingSpecificFunction.market_hall,
                OT_FunSzczegolowaBudynku.hala_widowiskowa => BuildingSpecificFunction.arena,
                OT_FunSzczegolowaBudynku.hala_wystawowa => BuildingSpecificFunction.exhibition_hall,
                OT_FunSzczegolowaBudynku.halowy_tor_gokartowy => BuildingSpecificFunction.indoor_go_kart_track,
                OT_FunSzczegolowaBudynku.hangar => BuildingSpecificFunction.hangar,
                OT_FunSzczegolowaBudynku.hipermarket_lub_supermarket => BuildingSpecificFunction.hypermarket_or_supermarket,
                OT_FunSzczegolowaBudynku.hospicjum => BuildingSpecificFunction.hospice,
                OT_FunSzczegolowaBudynku.hotel => BuildingSpecificFunction.hotel,
                OT_FunSzczegolowaBudynku.hotel_robotniczy => BuildingSpecificFunction.workers_hotel,
                OT_FunSzczegolowaBudynku.inna_placowka_edukacyjna => BuildingSpecificFunction.other_educational_facility,
                OT_FunSzczegolowaBudynku.inny_budynek_kultu_religijnego => BuildingSpecificFunction.other_religious_building,
                OT_FunSzczegolowaBudynku.inny_urzad_administracji_publicznej => BuildingSpecificFunction.other_public_administration_office,
                OT_FunSzczegolowaBudynku.internat_lub_bursa_szkolna => BuildingSpecificFunction.boarding_school_dormitory,
                OT_FunSzczegolowaBudynku.izba_wytrzezwien => BuildingSpecificFunction.sobering_up_station,
                OT_FunSzczegolowaBudynku.jednostka_ratownictwa_medycznego => BuildingSpecificFunction.emergency_medical_service_unit,
                OT_FunSzczegolowaBudynku.kapitanat_lub_bosmanat_portu => BuildingSpecificFunction.port_authority_office,
                OT_FunSzczegolowaBudynku.kaplica => BuildingSpecificFunction.chapel,
                OT_FunSzczegolowaBudynku.kasyno => BuildingSpecificFunction.casino,
                OT_FunSzczegolowaBudynku.kino => BuildingSpecificFunction.cinema,
                OT_FunSzczegolowaBudynku.klasztor => BuildingSpecificFunction.monastery,
                OT_FunSzczegolowaBudynku.klinika_weterynaryjna => BuildingSpecificFunction.veterinary_clinic,
                OT_FunSzczegolowaBudynku.klub_sportowy => BuildingSpecificFunction.sports_club,
                OT_FunSzczegolowaBudynku.klub_dyskoteka => BuildingSpecificFunction.club_disco,
                OT_FunSzczegolowaBudynku.korty_tenisowe => BuildingSpecificFunction.tennis_courts,
                OT_FunSzczegolowaBudynku.koszary => BuildingSpecificFunction.barracks,
                OT_FunSzczegolowaBudynku.kosciol => BuildingSpecificFunction.church,
                OT_FunSzczegolowaBudynku.kotlownia => BuildingSpecificFunction.boiler_room,
                OT_FunSzczegolowaBudynku.krematorium => BuildingSpecificFunction.crematorium,
                OT_FunSzczegolowaBudynku.kregielnia => BuildingSpecificFunction.bowling_alley,
                OT_FunSzczegolowaBudynku.kuria_metropolitalna => BuildingSpecificFunction.metropolitan_curia,
                OT_FunSzczegolowaBudynku.latarnia_morska => BuildingSpecificFunction.lighthouse,
                OT_FunSzczegolowaBudynku.lesniczowka => BuildingSpecificFunction.foresters_lodge,
                OT_FunSzczegolowaBudynku.lokomotywownia_lub_wagonownia => BuildingSpecificFunction.locomotive_depot_carriage_shed,
                OT_FunSzczegolowaBudynku.magazyn => BuildingSpecificFunction.warehouse,
                OT_FunSzczegolowaBudynku.meczet => BuildingSpecificFunction.mosque,
                OT_FunSzczegolowaBudynku.ministerstwo => BuildingSpecificFunction.ministry_building,
                OT_FunSzczegolowaBudynku.mlyn => BuildingSpecificFunction.mill,
                OT_FunSzczegolowaBudynku.motel => BuildingSpecificFunction.motel,
                OT_FunSzczegolowaBudynku.muzeum => BuildingSpecificFunction.museum,
                OT_FunSzczegolowaBudynku.myjnia_samochodowa => BuildingSpecificFunction.car_wash,
                OT_FunSzczegolowaBudynku.obserwatorium_lub_planetarium => BuildingSpecificFunction.observatory_or_planetarium,
                OT_FunSzczegolowaBudynku.opera => BuildingSpecificFunction.opera_house,
                OT_FunSzczegolowaBudynku.osrodek_pomocy_spolecznej => BuildingSpecificFunction.social_welfare_center,
                OT_FunSzczegolowaBudynku.osrodek_szkoleniowo_wypoczynkowy => BuildingSpecificFunction.training_leisure_center,
                OT_FunSzczegolowaBudynku.parking_wielopoziomowy => BuildingSpecificFunction.multi_story_parking_garage,
                OT_FunSzczegolowaBudynku.obiekt_handlowo_uslugowy => BuildingSpecificFunction.commercial_service_building,
                OT_FunSzczegolowaBudynku.pawilon_ogrodowy_lub_oranzeria => BuildingSpecificFunction.garden_pavilion_orangery,
                OT_FunSzczegolowaBudynku.pensjonat => BuildingSpecificFunction.guesthouse,
                OT_FunSzczegolowaBudynku.placowka_badawcza => BuildingSpecificFunction.research_facility,
                OT_FunSzczegolowaBudynku.placowka_dyplomatyczna_lub_konsularna => BuildingSpecificFunction.diplomatic_or_consular_office,
                OT_FunSzczegolowaBudynku.placowka_ochrony_zdrowia => BuildingSpecificFunction.healthcare_facility,
                OT_FunSzczegolowaBudynku.placowka_operatora_pocztowego => BuildingSpecificFunction.postal_operators_office,
                OT_FunSzczegolowaBudynku.placowka_opiekunczo_wychowawcza => BuildingSpecificFunction.care_educational_facility,
                OT_FunSzczegolowaBudynku.policja => BuildingSpecificFunction.police_station,
                OT_FunSzczegolowaBudynku.produkcyjny => BuildingSpecificFunction.production_building,
                OT_FunSzczegolowaBudynku.prokuratura => BuildingSpecificFunction.prosecutors_office,
                OT_FunSzczegolowaBudynku.przedszkole => BuildingSpecificFunction.kindergarten,
                OT_FunSzczegolowaBudynku.przejscie_graniczne => BuildingSpecificFunction.border_crossing,
                OT_FunSzczegolowaBudynku.rafineria => BuildingSpecificFunction.refinery,
                OT_FunSzczegolowaBudynku.restauracja => BuildingSpecificFunction.restaurant,
                OT_FunSzczegolowaBudynku.rezydencja_ambasadora => BuildingSpecificFunction.ambassadors_residence,
                OT_FunSzczegolowaBudynku.rezydencja_biskupia => BuildingSpecificFunction.bishops_residence,
                OT_FunSzczegolowaBudynku.rezydencja_prezydencka => BuildingSpecificFunction.presidential_residence,
                OT_FunSzczegolowaBudynku.sala_gimnastyczna => BuildingSpecificFunction.gym,
                OT_FunSzczegolowaBudynku.sanatorium => BuildingSpecificFunction.solarium,
                OT_FunSzczegolowaBudynku.sad => BuildingSpecificFunction.court_building,
                OT_FunSzczegolowaBudynku.schronisko_dla_nieletnich => BuildingSpecificFunction.juvenile_shelter,
                OT_FunSzczegolowaBudynku.schronisko_dla_zwierzat => BuildingSpecificFunction.animal_shelter,
                OT_FunSzczegolowaBudynku.schronisko_turystyczne => BuildingSpecificFunction.tourist_shelter,
                OT_FunSzczegolowaBudynku.siedziba_firmy_lub_firm => BuildingSpecificFunction.company_headquarters,
                OT_FunSzczegolowaBudynku.silos => BuildingSpecificFunction.silo,
                OT_FunSzczegolowaBudynku.spalarnia_smieci => BuildingSpecificFunction.waste_incinerator,
                OT_FunSzczegolowaBudynku.stacja_gazowa => BuildingSpecificFunction.gas_station,
                OT_FunSzczegolowaBudynku.stacja_hydrologiczna => BuildingSpecificFunction.hydrological_station,
                OT_FunSzczegolowaBudynku.stacja_kolejki_gorskiej_lub_wyciagu_krzeselkowego => BuildingSpecificFunction.mountain_railway_chairlift_station,
                OT_FunSzczegolowaBudynku.stacja_krwiodawstwa => BuildingSpecificFunction.blood_donation_station,
                OT_FunSzczegolowaBudynku.stacja_meteorologiczna => BuildingSpecificFunction.meteorological_station,
                OT_FunSzczegolowaBudynku.stacja_nadawcza_radia_i_telewizji => BuildingSpecificFunction.radio_and_tv_transmission_station,
                OT_FunSzczegolowaBudynku.stacja_nautyczna => BuildingSpecificFunction.nautical_station,
                OT_FunSzczegolowaBudynku.stacja_obslugi_pojazdow => BuildingSpecificFunction.vehicle_service_station,
                OT_FunSzczegolowaBudynku.stacja_paliw => BuildingSpecificFunction.fuel_station,
                OT_FunSzczegolowaBudynku.stacja_pomp => BuildingSpecificFunction.pumping_station,
                OT_FunSzczegolowaBudynku.stacja_sanitarno_epidemiologiczna => BuildingSpecificFunction.sanitary_epidemiological_station,
                OT_FunSzczegolowaBudynku.stacja_transformatorowa => BuildingSpecificFunction.transformer_station,
                OT_FunSzczegolowaBudynku.stajnia => BuildingSpecificFunction.stable,
                OT_FunSzczegolowaBudynku.starostwo_powiatowe => BuildingSpecificFunction.county_office,
                OT_FunSzczegolowaBudynku.straz_graniczna => BuildingSpecificFunction.border_guard,
                OT_FunSzczegolowaBudynku.straz_pozarna => BuildingSpecificFunction.fire_department,
                OT_FunSzczegolowaBudynku.strzelnica => BuildingSpecificFunction.gendarmerie,
                OT_FunSzczegolowaBudynku.synagoga => BuildingSpecificFunction.synagogue,
                OT_FunSzczegolowaBudynku.szklarnia_lub_cieplarnia => BuildingSpecificFunction.greenhouse_or_hothouse,
                OT_FunSzczegolowaBudynku.szkola_podstawowa => BuildingSpecificFunction.primary_school,
                OT_FunSzczegolowaBudynku.szkola_ponadpodstawowa => BuildingSpecificFunction.secondary_school,
                OT_FunSzczegolowaBudynku.szkoła_wyzsza => BuildingSpecificFunction.higher_education_institution_or_university,
                OT_FunSzczegolowaBudynku.szpital => BuildingSpecificFunction.hospital,
                OT_FunSzczegolowaBudynku.sztuczne_lodowisko => BuildingSpecificFunction.ice_rink,
                OT_FunSzczegolowaBudynku.teatr => BuildingSpecificFunction.theater,
                OT_FunSzczegolowaBudynku.terminal_portowy => BuildingSpecificFunction.port_terminal,
                OT_FunSzczegolowaBudynku.toaleta_publiczna => BuildingSpecificFunction.public_toilet,
                OT_FunSzczegolowaBudynku.ujezdzalnia => BuildingSpecificFunction.riding_hall,
                OT_FunSzczegolowaBudynku.urzad_celny => BuildingSpecificFunction.customs_office,
                OT_FunSzczegolowaBudynku.urzad_gminy => BuildingSpecificFunction.municipal_office,
                OT_FunSzczegolowaBudynku.urzad_marszalkowski => BuildingSpecificFunction.marshals_office,
                OT_FunSzczegolowaBudynku.urzad_miasta => BuildingSpecificFunction.city_hall,
                OT_FunSzczegolowaBudynku.urzad_miasta_i_gminy => BuildingSpecificFunction.city_and_municipality_office,
                OT_FunSzczegolowaBudynku.urzad_wojewodzki => BuildingSpecificFunction.voivodeship_office,
                OT_FunSzczegolowaBudynku.warsztat_remontowo_naprawczy => BuildingSpecificFunction.repair_workshop,
                OT_FunSzczegolowaBudynku.wiatrak => BuildingSpecificFunction.windmill,
                OT_FunSzczegolowaBudynku.zabudowania_koszarowe => BuildingSpecificFunction.barracks_buildings,
                OT_FunSzczegolowaBudynku.zabytek_niepelniacy_zadnej_funkcji_uzytkowej => BuildingSpecificFunction.monument_not_serving_any_functional_purpose,
                OT_FunSzczegolowaBudynku.zajazd => BuildingSpecificFunction.inn,
                OT_FunSzczegolowaBudynku.zajezdnia_autobusowa => BuildingSpecificFunction.bus_depot,
                OT_FunSzczegolowaBudynku.zajezdnia_tramwajowa => BuildingSpecificFunction.tram_depot,
                OT_FunSzczegolowaBudynku.zajezdnia_trolejbusowa => BuildingSpecificFunction.trolleybus_depot,
                OT_FunSzczegolowaBudynku.zaklad_karny => BuildingSpecificFunction.prison,
                OT_FunSzczegolowaBudynku.zaklad_karny_lub_poprawczy => BuildingSpecificFunction.prison_or_correctional_facility,
                OT_FunSzczegolowaBudynku.zaklad_poprawczy => BuildingSpecificFunction.correctional_facility,
                OT_FunSzczegolowaBudynku.zbiornik_na_ciecz => BuildingSpecificFunction.liquid_tank,
                OT_FunSzczegolowaBudynku.zbiornik_na_gaz => BuildingSpecificFunction.gas_tank,
                OT_FunSzczegolowaBudynku.zlobek => BuildingSpecificFunction.nursery,
                _ => throw new NotImplementedException(),
            };
        }
    }
}


