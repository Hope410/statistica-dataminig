/**C# deployment code of Neural Networks Model**/

/**==========================================================================
Before running the C# deployment code please read the following.

 STATISTICA variable names will be exported as-is into the C# deployment script;
please verify the resulting script to ensure that the variable names follow the C#
naming conventions and modify the names if necessary.

==========================================================================**/

using System;


public class Predict
{
   public static void __ET_MLP_19_4_2( double[] ContInputs, string[] CatInputs )
   {
     //"Input Variable" comment is added besides Input(Response) variables.

     int Cont_idx=0;
     int Cat_idx=0;
     double _price__ = ContInputs[Cont_idx++]; //Input Variable
     string _change__ = CatInputs[Cat_idx++]; //Input Variable
    double[] __statist_max_input = new double[1];
    __statist_max_input[0]= 3.17190000000000e-002;

    double[] __statist_min_input = new double[1];
    __statist_min_input[0]= 3.11350000000000e-002;

    double[] __statist_max_target = new double[2];
    __statist_max_target[0]= 1.00000000000000e+000;
    __statist_max_target[1]= 4.61822000000000e+002;

    double[] __statist_min_target = new double[2];
    __statist_min_target[0]= 0.00000000000000e+000;
    __statist_min_target[1]= 1.00000000000000e-003;


    double[,] __statist_i_h_wts = new double[4,19];

    __statist_i_h_wts[0,0]=-2.88344714211060e+000;
    __statist_i_h_wts[0,1]=-5.54877048953778e-001;
    __statist_i_h_wts[0,2]=-3.72801749808436e-001;
    __statist_i_h_wts[0,3]=4.36589873597687e-001;
    __statist_i_h_wts[0,4]=1.82221005514543e-001;
    __statist_i_h_wts[0,5]=2.79795477483115e-001;
    __statist_i_h_wts[0,6]=2.82868150227211e-001;
    __statist_i_h_wts[0,7]=-2.96948283177343e-001;
    __statist_i_h_wts[0,8]=3.21121429677780e-002;
    __statist_i_h_wts[0,9]=2.64568400612223e-001;
    __statist_i_h_wts[0,10]=1.30747164551970e-001;
    __statist_i_h_wts[0,11]=-2.27761157112426e-001;
    __statist_i_h_wts[0,12]=5.44532046322465e-001;
    __statist_i_h_wts[0,13]=-2.73709629639719e-001;
    __statist_i_h_wts[0,14]=1.62007601775675e-001;
    __statist_i_h_wts[0,15]=1.18696164881797e-001;
    __statist_i_h_wts[0,16]=1.02313545533750e-001;
    __statist_i_h_wts[0,17]=-8.22584006815183e-003;
    __statist_i_h_wts[0,18]=7.21480446485716e-002;

    __statist_i_h_wts[1,0]=2.06379355257633e+000;
    __statist_i_h_wts[1,1]=8.48275145789668e-001;
    __statist_i_h_wts[1,2]=1.03486469981829e-001;
    __statist_i_h_wts[1,3]=-1.99143930210930e-001;
    __statist_i_h_wts[1,4]=-3.26068619258959e-001;
    __statist_i_h_wts[1,5]=-4.65169371102876e-001;
    __statist_i_h_wts[1,6]=-5.24243890746950e-001;
    __statist_i_h_wts[1,7]=-1.60225779470656e-002;
    __statist_i_h_wts[1,8]=2.06986030436062e-002;
    __statist_i_h_wts[1,9]=9.97509493346013e-003;
    __statist_i_h_wts[1,10]=1.84848488430075e-002;
    __statist_i_h_wts[1,11]=3.00131823964594e-001;
    __statist_i_h_wts[1,12]=4.62043865711876e-002;
    __statist_i_h_wts[1,13]=6.90907288583591e-001;
    __statist_i_h_wts[1,14]=-5.77675009629804e-002;
    __statist_i_h_wts[1,15]=-1.16500760333664e-001;
    __statist_i_h_wts[1,16]=-4.72942840638626e-002;
    __statist_i_h_wts[1,17]=1.54543195008341e-001;
    __statist_i_h_wts[1,18]=2.34560733849727e-001;

    __statist_i_h_wts[2,0]=-5.54435751097967e-001;
    __statist_i_h_wts[2,1]=3.67591387704951e-001;
    __statist_i_h_wts[2,2]=3.72040098006641e-001;
    __statist_i_h_wts[2,3]=5.43347004094304e-001;
    __statist_i_h_wts[2,4]=5.04454926456622e-001;
    __statist_i_h_wts[2,5]=4.84451793389450e-001;
    __statist_i_h_wts[2,6]=5.01603210281130e-001;
    __statist_i_h_wts[2,7]=5.28017025558589e-001;
    __statist_i_h_wts[2,8]=-2.12378950036644e-002;
    __statist_i_h_wts[2,9]=1.01088410584351e-001;
    __statist_i_h_wts[2,10]=-1.49848613450651e-001;
    __statist_i_h_wts[2,11]=-3.38309701881277e-001;
    __statist_i_h_wts[2,12]=-2.91599951131619e-001;
    __statist_i_h_wts[2,13]=-3.23130536099025e-001;
    __statist_i_h_wts[2,14]=-3.47076851892632e-001;
    __statist_i_h_wts[2,15]=-3.90425401609577e-001;
    __statist_i_h_wts[2,16]=-3.70205424361845e-001;
    __statist_i_h_wts[2,17]=-3.06227221471650e-001;
    __statist_i_h_wts[2,18]=-2.58941959198154e-001;

    __statist_i_h_wts[3,0]=7.09876066120949e-001;
    __statist_i_h_wts[3,1]=1.48687170935886e-001;
    __statist_i_h_wts[3,2]=9.24200774539317e-001;
    __statist_i_h_wts[3,3]=1.94704155991594e+000;
    __statist_i_h_wts[3,4]=1.94909625171341e+000;
    __statist_i_h_wts[3,5]=1.11348052047137e+000;
    __statist_i_h_wts[3,6]=6.16644175809442e-001;
    __statist_i_h_wts[3,7]=5.42751865971509e-001;
    __statist_i_h_wts[3,8]=-2.13266542112384e-003;
    __statist_i_h_wts[3,9]=-1.17776692711105e+000;
    __statist_i_h_wts[3,10]=-3.83579317554571e+000;
    __statist_i_h_wts[3,11]=-7.98614471014533e-002;
    __statist_i_h_wts[3,12]=1.48973613154172e+000;
    __statist_i_h_wts[3,13]=-1.86309584101662e+000;
    __statist_i_h_wts[3,14]=-1.34725721933168e+000;
    __statist_i_h_wts[3,15]=-3.39273209336770e-001;
    __statist_i_h_wts[3,16]=-3.11512433921198e-001;
    __statist_i_h_wts[3,17]=-5.62407710211605e-002;
    __statist_i_h_wts[3,18]=-6.56094678494765e-002;

    double[,] __statist_h_o_wts = new double[2,4];

    __statist_h_o_wts[0,0]=-4.82869768973645e-001;
    __statist_h_o_wts[0,1]=-8.80648733107190e-001;
    __statist_h_o_wts[0,2]=1.13130747965903e+000;
    __statist_h_o_wts[0,3]=7.28329001418941e-002;

    __statist_h_o_wts[1,0]=1.22228469475213e-002;
    __statist_h_o_wts[1,1]=1.00051187085043e-001;
    __statist_h_o_wts[1,2]=6.03526764282902e-003;
    __statist_h_o_wts[1,3]=-4.94292076874636e-004;

    double[] __statist_hidden_bias = new double[4];
    __statist_hidden_bias[0]=7.98839943069812e-001;
    __statist_hidden_bias[1]=7.13177692325186e-001;
    __statist_hidden_bias[2]=5.55906840563767e-001;
    __statist_hidden_bias[3]=-3.11090034983259e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=7.55024126863651e-001;
    __statist_output_bias[1]=-8.54172865901313e-002;

    double[] __statist_inputs = new double[19];

    double[] __statist_hidden = new double[4];

    double[] __statist_outputs = new double[2];
    __statist_outputs[0] = -1.0e+307;
    __statist_outputs[1] = -1.0e+307;

    __statist_inputs[0]=_price__;

    if( _change__=="-1")
    {
     __statist_inputs[1]=1;
    }
    else
    {
     __statist_inputs[1]=0;
    }

    if( _change__=="-2")
    {
     __statist_inputs[2]=1;
    }
    else
    {
     __statist_inputs[2]=0;
    }

    if( _change__=="-3")
    {
     __statist_inputs[3]=1;
    }
    else
    {
     __statist_inputs[3]=0;
    }

    if( _change__=="-4")
    {
     __statist_inputs[4]=1;
    }
    else
    {
     __statist_inputs[4]=0;
    }

    if( _change__=="-5")
    {
     __statist_inputs[5]=1;
    }
    else
    {
     __statist_inputs[5]=0;
    }

    if( _change__=="-6")
    {
     __statist_inputs[6]=1;
    }
    else
    {
     __statist_inputs[6]=0;
    }

    if( _change__=="-7")
    {
     __statist_inputs[7]=1;
    }
    else
    {
     __statist_inputs[7]=0;
    }

    if( _change__=="-8")
    {
     __statist_inputs[8]=1;
    }
    else
    {
     __statist_inputs[8]=0;
    }

    if( _change__=="0")
    {
     __statist_inputs[9]=1;
    }
    else
    {
     __statist_inputs[9]=0;
    }

    if( _change__=="1")
    {
     __statist_inputs[10]=1;
    }
    else
    {
     __statist_inputs[10]=0;
    }

    if( _change__=="2")
    {
     __statist_inputs[11]=1;
    }
    else
    {
     __statist_inputs[11]=0;
    }

    if( _change__=="3")
    {
     __statist_inputs[12]=1;
    }
    else
    {
     __statist_inputs[12]=0;
    }

    if( _change__=="4")
    {
     __statist_inputs[13]=1;
    }
    else
    {
     __statist_inputs[13]=0;
    }

    if( _change__=="5")
    {
     __statist_inputs[14]=1;
    }
    else
    {
     __statist_inputs[14]=0;
    }

    if( _change__=="6")
    {
     __statist_inputs[15]=1;
    }
    else
    {
     __statist_inputs[15]=0;
    }

    if( _change__=="7")
    {
     __statist_inputs[16]=1;
    }
    else
    {
     __statist_inputs[16]=0;
    }

    if( _change__=="8")
    {
     __statist_inputs[17]=1;
    }
    else
    {
     __statist_inputs[17]=0;
    }

    if( _change__=="9")
    {
     __statist_inputs[18]=1;
    }
    else
    {
     __statist_inputs[18]=0;
    }

    double __statist_delta=0;
    double __statist_maximum=1;
    double __statist_minimum=0;
    int __statist_ncont_inputs=1;

    /*scale continuous inputs*/
    for(int __statist_i=0;__statist_i < __statist_ncont_inputs;__statist_i++)
    {
     __statist_delta = (__statist_maximum-__statist_minimum)/(__statist_max_input[__statist_i]-__statist_min_input[__statist_i]);
     __statist_inputs[__statist_i] = __statist_minimum - __statist_delta*__statist_min_input[__statist_i]+ __statist_delta*__statist_inputs[__statist_i];
    }

    int __statist_ninputs=19;
    int __statist_nhidden=4;

    /*Compute feed forward signals from Input layer to hidden layer*/
    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)
    {
      __statist_hidden[__statist_row]=0.0;
      for(int __statist_col=0;__statist_col < __statist_ninputs;__statist_col++)
      {
       __statist_hidden[__statist_row]= __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row,__statist_col]*__statist_inputs[__statist_col]);
      }
     __statist_hidden[__statist_row]=__statist_hidden[__statist_row]+__statist_hidden_bias[__statist_row];
    }

    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)
    {
      if(__statist_hidden[__statist_row]>100.0)
      {
       __statist_hidden[__statist_row] = 1.0;
      }
      else
      {
       if(__statist_hidden[__statist_row]<-100.0)
       {
        __statist_hidden[__statist_row] = -1.0;
       }
       else
       {
        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);
       }
      }
    }

    int __statist_noutputs=2;

    /*Compute feed forward signals from hidden layer to output layer*/
    for(int __statist_row2=0;__statist_row2 < __statist_noutputs;__statist_row2++)
    {
     __statist_outputs[__statist_row2]=0.0;
    for(int __statist_col2=0;__statist_col2 < __statist_nhidden;__statist_col2++)
      {
       __statist_outputs[__statist_row2]= __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2,__statist_col2]*__statist_hidden[__statist_col2]);
      }
     __statist_outputs[__statist_row2]=__statist_outputs[__statist_row2]+__statist_output_bias[__statist_row2];
    }



    /*Unscale continuous targets*/
    __statist_delta=0;
    for(int __statist_i=0;__statist_i < __statist_noutputs;__statist_i++)
    {
     __statist_delta = (__statist_maximum-__statist_minimum)/(__statist_max_target[__statist_i]-__statist_min_target[__statist_i]);
     __statist_outputs[__statist_i] = (__statist_outputs[__statist_i] - __statist_minimum + __statist_delta*__statist_min_target[__statist_i])/__statist_delta;
    }


      for(int __statist_ii=0; __statist_ii < __statist_noutputs; __statist_ii++)
      {
        Console.WriteLine(" Prediction{0} = {1}", __statist_ii+1, __statist_outputs[__statist_ii]);
      }


   }

   public static void Main (string[] args) {
     int argID = 0;
     double[] ContInputs = new double[1];
     int contID = 0;
     string[] CatInputs = new string[1];
     int catID = 0;

     if (args.Length >= 2)
     {
       ContInputs[contID++] = Double.Parse(args[argID++]);
       CatInputs[catID++] = args[argID++];
     }
     else
     {
       string Comment = "";
       string Comment1 = "**************************************************************************\n";
       Comment += Comment1;
       string Comment2 = "Please enter at least 2 command line parameters in the following order for \nthe program to Predict.\n";
       Comment += Comment2;
       Comment += Comment1;
       string Comment4 = "price  Type - double (or) integer\n";
       Comment += Comment4;
       string Comment5 = "change  Type - String (categories are { \"-1\"  \"-2\"  \"-3\"  \"-4\"  \"-5\"  \"-6\"  \"-7\"  \"-8\"  \"0\"  \"1\"  \"2\"  \"3\"  \"4\"  \"5\"  \"6\"  \"7\"  \"8\"  \"9\" } )\n";
       Comment += Comment5;
       Comment += Comment1;
       System.Console.WriteLine(Comment);
       System.Environment.Exit(1);
     }
     __ET_MLP_19_4_2( ContInputs, CatInputs );
   }

}
