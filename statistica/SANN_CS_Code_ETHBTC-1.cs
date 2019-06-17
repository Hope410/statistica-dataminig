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
   public static void __ET_MLP_19_6_2( double[] ContInputs, string[] CatInputs )
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


    double[,] __statist_i_h_wts = new double[6,19];

    __statist_i_h_wts[0,0]=2.64592706001712e+002;
    __statist_i_h_wts[0,1]=1.92575965493992e+002;
    __statist_i_h_wts[0,2]=1.44487070878114e+002;
    __statist_i_h_wts[0,3]=5.31179885788912e+000;
    __statist_i_h_wts[0,4]=-2.83185609649095e+000;
    __statist_i_h_wts[0,5]=1.14288785671277e+000;
    __statist_i_h_wts[0,6]=4.74298358786028e-001;
    __statist_i_h_wts[0,7]=-2.37829028222908e+000;
    __statist_i_h_wts[0,8]=5.74419649443214e-002;
    __statist_i_h_wts[0,9]=-3.83107310960202e+001;
    __statist_i_h_wts[0,10]=-9.73450964412101e+001;
    __statist_i_h_wts[0,11]=-8.46671083578811e+001;
    __statist_i_h_wts[0,12]=-1.89158121351697e+002;
    __statist_i_h_wts[0,13]=-2.66764321616122e+001;
    __statist_i_h_wts[0,14]=7.35008689365768e+000;
    __statist_i_h_wts[0,15]=-2.74446691304927e+000;
    __statist_i_h_wts[0,16]=-2.35989298440305e+000;
    __statist_i_h_wts[0,17]=-2.05891597239177e+001;
    __statist_i_h_wts[0,18]=-2.09611944508015e+001;

    __statist_i_h_wts[1,0]=6.88659413290807e-001;
    __statist_i_h_wts[1,1]=1.84220409442430e+001;
    __statist_i_h_wts[1,2]=1.98286074208591e+001;
    __statist_i_h_wts[1,3]=-9.88809635103533e+001;
    __statist_i_h_wts[1,4]=-2.31361735758947e+001;
    __statist_i_h_wts[1,5]=-7.92531556781684e+000;
    __statist_i_h_wts[1,6]=-7.22613375281841e+000;
    __statist_i_h_wts[1,7]=-9.88366351751114e+000;
    __statist_i_h_wts[1,8]=-2.41305778488028e-002;
    __statist_i_h_wts[1,9]=-9.34592379771734e+001;
    __statist_i_h_wts[1,10]=1.87579781166283e+001;
    __statist_i_h_wts[1,11]=1.91378296580202e+001;
    __statist_i_h_wts[1,12]=1.39447070590837e+001;
    __statist_i_h_wts[1,13]=3.39187304115666e+001;
    __statist_i_h_wts[1,14]=3.37631160207762e+001;
    __statist_i_h_wts[1,15]=2.04952677845377e+001;
    __statist_i_h_wts[1,16]=1.64758869281484e+001;
    __statist_i_h_wts[1,17]=1.40052482992309e+001;
    __statist_i_h_wts[1,18]=1.40344684773815e+001;

    __statist_i_h_wts[2,0]=7.38331870359736e-001;
    __statist_i_h_wts[2,1]=4.21213835914008e+000;
    __statist_i_h_wts[2,2]=3.98950923286777e+001;
    __statist_i_h_wts[2,3]=2.83869917458201e-001;
    __statist_i_h_wts[2,4]=1.64798062384275e+001;
    __statist_i_h_wts[2,5]=1.04415720637028e+001;
    __statist_i_h_wts[2,6]=1.04825891854637e+001;
    __statist_i_h_wts[2,7]=1.76183818943951e+001;
    __statist_i_h_wts[2,8]=-2.16789578661155e-002;
    __statist_i_h_wts[2,9]=-9.56496252210921e+001;
    __statist_i_h_wts[2,10]=4.18595559654975e+000;
    __statist_i_h_wts[2,11]=4.54205353105614e+000;
    __statist_i_h_wts[2,12]=-6.53713680064576e+000;
    __statist_i_h_wts[2,13]=7.67878928412813e+000;
    __statist_i_h_wts[2,14]=1.04622535791318e+001;
    __statist_i_h_wts[2,15]=5.72900654595379e+000;
    __statist_i_h_wts[2,16]=1.79021688363914e+000;
    __statist_i_h_wts[2,17]=-1.60543348343814e+001;
    __statist_i_h_wts[2,18]=-1.87144565819150e+001;

    __statist_i_h_wts[3,0]=3.95420731092353e+002;
    __statist_i_h_wts[3,1]=1.35034017065363e+002;
    __statist_i_h_wts[3,2]=1.02166689252894e+002;
    __statist_i_h_wts[3,3]=6.28116254748056e+001;
    __statist_i_h_wts[3,4]=5.44249808428460e+000;
    __statist_i_h_wts[3,5]=-3.46349190051165e+000;
    __statist_i_h_wts[3,6]=-2.59619075704808e+000;
    __statist_i_h_wts[3,7]=1.85366488293450e+000;
    __statist_i_h_wts[3,8]=1.69628406240096e-002;
    __statist_i_h_wts[3,9]=-6.13408373703783e+001;
    __statist_i_h_wts[3,10]=-1.56973151261156e+002;
    __statist_i_h_wts[3,11]=-1.34550625971235e+002;
    __statist_i_h_wts[3,12]=-6.52623061603900e+001;
    __statist_i_h_wts[3,13]=-2.89869367556697e+001;
    __statist_i_h_wts[3,14]=-6.74578653462507e+001;
    __statist_i_h_wts[3,15]=2.28726169196686e+000;
    __statist_i_h_wts[3,16]=-1.15870292618168e+001;
    __statist_i_h_wts[3,17]=1.44433199388258e+001;
    __statist_i_h_wts[3,18]=1.43992848960285e+001;

    __statist_i_h_wts[4,0]=1.20286837300855e+002;
    __statist_i_h_wts[4,1]=4.81340996593846e+000;
    __statist_i_h_wts[4,2]=2.72568320077326e+001;
    __statist_i_h_wts[4,3]=7.86138756478522e+001;
    __statist_i_h_wts[4,4]=-6.53144282043478e-001;
    __statist_i_h_wts[4,5]=1.30259369810297e+000;
    __statist_i_h_wts[4,6]=9.47927385683834e-001;
    __statist_i_h_wts[4,7]=-2.80575956404529e+000;
    __statist_i_h_wts[4,8]=-6.00983929424710e-003;
    __statist_i_h_wts[4,9]=-6.01634176392807e+001;
    __statist_i_h_wts[4,10]=-6.34646845820636e+001;
    __statist_i_h_wts[4,11]=-5.65990729247692e+001;
    __statist_i_h_wts[4,12]=-3.54840734595756e+001;
    __statist_i_h_wts[4,13]=3.69186521799428e+001;
    __statist_i_h_wts[4,14]=2.27522125657896e+001;
    __statist_i_h_wts[4,15]=1.18213061101296e+001;
    __statist_i_h_wts[4,16]=-4.64415148462152e+000;
    __statist_i_h_wts[4,17]=-2.90033664732356e+000;
    __statist_i_h_wts[4,18]=-2.55984835435711e+000;

    __statist_i_h_wts[5,0]=1.02155558279606e+001;
    __statist_i_h_wts[5,1]=-2.92040980400879e+000;
    __statist_i_h_wts[5,2]=5.80723744780280e+001;
    __statist_i_h_wts[5,3]=-2.38913711717300e+001;
    __statist_i_h_wts[5,4]=-6.53412833424992e-001;
    __statist_i_h_wts[5,5]=3.05019926869392e+000;
    __statist_i_h_wts[5,6]=3.64251027118373e+000;
    __statist_i_h_wts[5,7]=2.10197017405439e+000;
    __statist_i_h_wts[5,8]=1.57295443515365e-002;
    __statist_i_h_wts[5,9]=-5.09196070081505e+000;
    __statist_i_h_wts[5,10]=-1.65713072007252e+001;
    __statist_i_h_wts[5,11]=-1.10042695637285e+001;
    __statist_i_h_wts[5,12]=-1.44101958654365e+002;
    __statist_i_h_wts[5,13]=4.17776521678953e+001;
    __statist_i_h_wts[5,14]=5.32808145571555e+001;
    __statist_i_h_wts[5,15]=1.26521441967245e+001;
    __statist_i_h_wts[5,16]=1.40338544579624e+001;
    __statist_i_h_wts[5,17]=7.81008921842222e+000;
    __statist_i_h_wts[5,18]=7.36541277810592e+000;

    double[,] __statist_h_o_wts = new double[2,6];

    __statist_h_o_wts[0,0]=-6.90677952588751e-001;
    __statist_h_o_wts[0,1]=-1.93562085031875e+001;
    __statist_h_o_wts[0,2]=1.90771111248254e+001;
    __statist_h_o_wts[0,3]=7.19315265886506e-001;
    __statist_h_o_wts[0,4]=-1.23651436319537e-001;
    __statist_h_o_wts[0,5]=1.61591172391944e-001;

    __statist_h_o_wts[1,0]=4.69145914437721e-003;
    __statist_h_o_wts[1,1]=-2.08021833712435e-003;
    __statist_h_o_wts[1,2]=-8.91280201248961e-004;
    __statist_h_o_wts[1,3]=-9.59094394495071e-003;
    __statist_h_o_wts[1,4]=1.86291676398783e-003;
    __statist_h_o_wts[1,5]=4.99868112752067e-003;

    double[] __statist_hidden_bias = new double[6];
    __statist_hidden_bias[0]=-1.36742738199092e+002;
    __statist_hidden_bias[1]=-1.77130201565695e+001;
    __statist_hidden_bias[2]=-3.14575576228276e+000;
    __statist_hidden_bias[3]=-1.93972693892584e+002;
    __statist_hidden_bias[4]=-4.48942856246847e+001;
    __statist_hidden_bias[5]=-5.05464373302207e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=3.57221970208677e-001;
    __statist_output_bias[1]=3.67621292740668e-003;

    double[] __statist_inputs = new double[19];

    double[] __statist_hidden = new double[6];

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
    int __statist_nhidden=6;

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
       __statist_hidden[__statist_row] = 0.0;
      }
      else
      {
      __statist_hidden[__statist_row] = 1.0/(1.0+Math.Exp(-__statist_hidden[__statist_row]));
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

    for(int __statist_row=0;__statist_row < __statist_noutputs;__statist_row++)
    {
     if(__statist_outputs[__statist_row]>100.0)
     {
      __statist_outputs[__statist_row] = 1.0;
     }
     else
     {
      if(__statist_outputs[__statist_row]<-100.0)
      {
       __statist_outputs[__statist_row] = -1.0;
      }
      else
      {
       __statist_outputs[__statist_row] = Math.Tanh(__statist_outputs[__statist_row]);
      }
     }
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
     __ET_MLP_19_6_2( ContInputs, CatInputs );
   }

}
