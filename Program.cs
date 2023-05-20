using System;

class Code{
    static void Main(string[]args){
        bool end = true;
        do{
            Console.Write("DNA : ");
            string dna = Console.ReadLine();

            if (IsValidSequence(dna) == true){
                Console.WriteLine("Current half DNA sequence : {0}",dna);
                bool outloop = true;
                do{
                    Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                   string yn = Console.ReadLine();
                    switch(yn){
                        case "Y" :
                            Console.WriteLine("Replicated half DNA sequence : {0}",ReplicateSeqeunce(dna));
                            outloop = false;
                            break;
                        case "N" :
                            outloop = false;
                            break;
                        default :
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }while(outloop);
            }else if (IsValidSequence(dna) == false){
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            bool outloop2 = true;
            do{
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                string yn2 = Console.ReadLine();
                switch(yn2){
                    case "Y" :
                        outloop2 = false;
                        break;
                    case "N" :
                        end = false;
                        outloop2 = false;
                        break;
                    default :
                        Console.WriteLine("Please input Y or N.");
                        break;
                }
            }while(outloop2);
        }while(end);
    }

    static bool IsValidSequence(string halfDNASequence){
	    foreach(char nucleotide in halfDNASequence)
	    {
    	    if(!"ATCG".Contains(nucleotide)){
        	    return false;
    	    }
	    }
	    return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence){
	    string result = "";
	    foreach(char nucleotide in halfDNASequence){
    	    result += "TAGC"["ATCG".IndexOf(nucleotide)];
	    }
	    return result;
    }

}
