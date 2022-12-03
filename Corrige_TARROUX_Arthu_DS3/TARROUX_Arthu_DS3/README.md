listes de mes erreur:
Form 1:

ajouterUnÉvénementToolStripMenuItem_Click:

	form_Add_Event.Owner= this; //oublie de la présition;

ouvrirToolStripMenuItem_Click:

	 int nb = int.Parse(reader.ReadLine()); //oublie de Line -> le suivant ne commance donc pas a celle d'aprés;
	 Maj_ListVieaw //pour mettre a jour le tab;


Form 2 :
Form_add_event:

	bouble heure : <= pour avoir 23H

boutton_ok_click:

	string temp_1 = (dateTimePicker1.Value.ToString("dd/MM/yyyy") +" "+ comboBox_SH.Text +":"+ comboBox_SM.Text); 
		//oublie de passer la value en string + ne prendre que jout moius années
	DateTime temp_end = DateTime.Parse(temp_2); // oublie de changer à 2


class:

	<DateTimeX>.ToString("dd/MM/yyyy HH:mm"); afficher les dates plus proprement //*4:
	//startS+endS(tpropiété sring)  ++ fonction All (appelée pour l'ajout dans le tableaux);
 


