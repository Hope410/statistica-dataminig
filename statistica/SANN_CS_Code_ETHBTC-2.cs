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

    __statist_i_h_wts[0,0]=1.49687321172340e+001;
    __statist_i_h_wts[0,1]=6.41821576348940e+000;
    __statist_i_h_wts[0,2]=-7.43624240463403e-001;
    __statist_i_h_wts[0,3]=-2.17103854658547e+000;
    __statist_i_h_wts[0,4]=3.65677284204817e+000;
    __statist_i_h_wts[0,5]=1.13008642370105e+000;
    __statist_i_h_wts[0,6]=1.23309714866940e+000;
    __statist_i_h_wts[0,7]=2.37879603871509e-001;
    __statist_i_h_wts[0,8]=7.44276611775874e-003;
    __statist_i_h_wts[0,9]=3.30352671300219e-001;
    __statist_i_h_wts[0,10]=-8.37209247826204e+000;
    __statist_i_h_wts[0,11]=-7.50996705613416e+000;
    __statist_i_h_wts[0,12]=-3.33788801838678e-001;
    __statist_i_h_wts[0,13]=3.01940043972660e+000;
    __statist_i_h_wts[0,14]=-5.68106925491446e-001;
    __statist_i_h_wts[0,15]=3.81776438119013e-002;
    __statist_i_h_wts[0,16]=2.06071383611584e-001;
    __statist_i_h_wts[0,17]=-2.73319776649514e+000;
    __statist_i_h_wts[0,18]=-2.68736098718170e+000;

    __statist_i_h_wts[1,0]=1.14384468011922e+001;
    __statist_i_h_wts[1,1]=8.39363635967782e+000;
    __statist_i_h_wts[1,2]=-2.00059367705989e+000;
    __statist_i_h_wts[1,3]=-3.47363092968737e+000;
    __statist_i_h_wts[1,4]=2.29435474276640e+000;
    __statist_i_h_wts[1,5]=8.87554018598869e-001;
    __statist_i_h_wts[1,6]=1.09981455092766e+000;
    __statist_i_h_wts[1,7]=-1.34492597670111e-001;
    __statist_i_h_wts[1,8]=-3.71297518327530e-002;
    __statist_i_h_wts[1,9]=-2.82299247465026e+000;
    __statist_i_h_wts[1,10]=-4.26311177700865e+000;
    __statist_i_h_wts[1,11]=-5.11515499913988e+000;
    __statist_i_h_wts[1,12]=-1.15461035650924e+000;
    __statist_i_h_wts[1,13]=-8.97168779698476e-002;
    __statist_i_h_wts[1,14]=-1.46211652005295e+000;
    __statist_i_h_wts[1,15]=-8.67827102043497e-001;
    __statist_i_h_wts[1,16]=-9.02578122353473e-001;
    __statist_i_h_wts[1,17]=1.80996321596035e+000;
    __statist_i_h_wts[1,18]=1.79528353237378e+000;

    __statist_i_h_wts[2,0]=-1.71096598572380e+000;
    __statist_i_h_wts[2,1]=1.04537097542340e+000;
    __statist_i_h_wts[2,2]=-1.65828242624763e+000;
    __statist_i_h_wts[2,3]=2.63059124565717e-001;
    __statist_i_h_wts[2,4]=1.19463578724811e+000;
    __statist_i_h_wts[2,5]=-1.58481326539527e-001;
    __statist_i_h_wts[2,6]=-2.04072721403954e-001;
    __statist_i_h_wts[2,7]=-3.66520977727942e-001;
    __statist_i_h_wts[2,8]=3.84662511122276e-003;
    __statist_i_h_wts[2,9]=-2.81995110421698e-001;
    __statist_i_h_wts[2,10]=-3.15415324514020e+000;
    __statist_i_h_wts[2,11]=-7.90906201637414e-001;
    __statist_i_h_wts[2,12]=1.53849752388327e+000;
    __statist_i_h_wts[2,13]=-1.01112132070441e+000;
    __statist_i_h_wts[2,14]=5.15410054567048e-001;
    __statist_i_h_wts[2,15]=6.14928509923828e-001;
    __statist_i_h_wts[2,16]=5.74106845677693e-001;
    __statist_i_h_wts[2,17]=3.17718219234748e-001;
    __statist_i_h_wts[2,18]=2.58222554937775e-001;

    __statist_i_h_wts[3,0]=6.20117046707164e-001;
    __statist_i_h_wts[3,1]=-2.49992854008360e-002;
    __statist_i_h_wts[3,2]=2.15647864036570e-001;
    __statist_i_h_wts[3,3]=-4.99932881277662e-001;
    __statist_i_h_wts[3,4]=-1.20194283490539e-001;
    __statist_i_h_wts[3,5]=4.81477809753696e-001;
    __statist_i_h_wts[3,6]=1.90156023605102e-002;
    __statist_i_h_wts[3,7]=4.96901915840416e-001;
    __statist_i_h_wts[3,8]=1.03118254936797e-003;
    __statist_i_h_wts[3,9]=-8.69980008696361e-001;
    __statist_i_h_wts[3,10]=-4.47625758230847e-001;
    __statist_i_h_wts[3,11]=1.48078456159224e+000;
    __statist_i_h_wts[3,12]=-1.68651078303200e+000;
    __statist_i_h_wts[3,13]=9.94204679342539e-001;
    __statist_i_h_wts[3,14]=-1.23423913391500e-001;
    __statist_i_h_wts[3,15]=-6.44498135456683e-001;
    __statist_i_h_wts[3,16]=-6.51910843212830e-001;
    __statist_i_h_wts[3,17]=-3.75025572158042e-002;
    __statist_i_h_wts[3,18]=-2.09526732700389e-002;

    __statist_i_h_wts[4,0]=-8.95206924078150e-002;
    __statist_i_h_wts[4,1]=3.44827908034171e+000;
    __statist_i_h_wts[4,2]=1.35565076387118e-001;
    __statist_i_h_wts[4,3]=6.33885806611664e-001;
    __statist_i_h_wts[4,4]=2.91345894487157e+000;
    __statist_i_h_wts[4,5]=1.25648750662884e+000;
    __statist_i_h_wts[4,6]=1.80659031242604e+000;
    __statist_i_h_wts[4,7]=9.54376172644420e-001;
    __statist_i_h_wts[4,8]=-2.78051500372401e-002;
    __statist_i_h_wts[4,9]=-1.50993997089540e+000;
    __statist_i_h_wts[4,10]=9.23527708152507e-001;
    __statist_i_h_wts[4,11]=-1.25733671415389e-001;
    __statist_i_h_wts[4,12]=-3.24570129815685e-001;
    __statist_i_h_wts[4,13]=-4.72878887421978e+000;
    __statist_i_h_wts[4,14]=-2.13901349361795e+000;
    __statist_i_h_wts[4,15]=-7.23841631188105e-001;
    __statist_i_h_wts[4,16]=-7.56442496905388e-001;
    __statist_i_h_wts[4,17]=-1.33269508572837e+000;
    __statist_i_h_wts[4,18]=-1.31541388820735e+000;

    __statist_i_h_wts[5,0]=-5.53055040884179e-001;
    __statist_i_h_wts[5,1]=6.80660036883740e+000;
    __statist_i_h_wts[5,2]=-2.17531899994301e+000;
    __statist_i_h_wts[5,3]=-3.99516082587544e-001;
    __statist_i_h_wts[5,4]=2.89764060730409e+000;
    __statist_i_h_wts[5,5]=2.92597354738613e-001;
    __statist_i_h_wts[5,6]=1.10864155266266e+000;
    __statist_i_h_wts[5,7]=-1.55628984808841e-001;
    __statist_i_h_wts[5,8]=-5.34382387820215e-002;
    __statist_i_h_wts[5,9]=-4.06533474457306e+000;
    __statist_i_h_wts[5,10]=1.19307761913279e+000;
    __statist_i_h_wts[5,11]=-1.45535710500967e-001;
    __statist_i_h_wts[5,12]=3.08704645177732e-001;
    __statist_i_h_wts[5,13]=-2.57007850206349e+000;
    __statist_i_h_wts[5,14]=-1.05751168863833e+000;
    __statist_i_h_wts[5,15]=-1.62263454942060e-001;
    __statist_i_h_wts[5,16]=-1.94041901396455e-001;
    __statist_i_h_wts[5,17]=-1.06100580517851e+000;
    __statist_i_h_wts[5,18]=-1.05368151152442e+000;

    double[,] __statist_h_o_wts = new double[2,6];

    __statist_h_o_wts[0,0]=3.89643035291416e-001;
    __statist_h_o_wts[0,1]=-3.27328609684873e-001;
    __statist_h_o_wts[0,2]=3.44209165101585e-001;
    __statist_h_o_wts[0,3]=-1.99911109815239e-001;
    __statist_h_o_wts[0,4]=3.20033124408981e+000;
    __statist_h_o_wts[0,5]=-2.22556777083489e+000;

    __statist_h_o_wts[1,0]=2.94989470562634e-003;
    __statist_h_o_wts[1,1]=-4.43356037024964e-003;
    __statist_h_o_wts[1,2]=1.08918528551069e-002;
    __statist_h_o_wts[1,3]=8.64320663359230e-003;
    __statist_h_o_wts[1,4]=-5.33521325678769e-003;
    __statist_h_o_wts[1,5]=3.46396323635084e-003;

    double[] __statist_hidden_bias = new double[6];
    __statist_hidden_bias[0]=-8.81924995306406e+000;
    __statist_hidden_bias[1]=-6.03493761771080e+000;
    __statist_hidden_bias[2]=-1.15999474814716e+000;
    __statist_hidden_bias[3]=-1.47611211866630e+000;
    __statist_hidden_bias[4]=-1.02590486614445e+000;
    __statist_hidden_bias[5]=-5.10327600170343e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=1.04192187701448e-001;
    __statist_output_bias[1]=8.80581111792732e-004;

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
