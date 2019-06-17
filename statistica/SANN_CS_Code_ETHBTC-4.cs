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

    __statist_i_h_wts[0,0]=5.26403812701554e-002;
    __statist_i_h_wts[0,1]=-8.33860606462234e-001;
    __statist_i_h_wts[0,2]=-9.86049827565045e-001;
    __statist_i_h_wts[0,3]=1.23285071649220e+000;
    __statist_i_h_wts[0,4]=-1.55034688217155e+000;
    __statist_i_h_wts[0,5]=9.78449175450255e-002;
    __statist_i_h_wts[0,6]=-2.35735392904453e+000;
    __statist_i_h_wts[0,7]=-5.47775564366681e+000;
    __statist_i_h_wts[0,8]=-2.74365582242525e-002;
    __statist_i_h_wts[0,9]=1.31879209160756e+000;
    __statist_i_h_wts[0,10]=2.27480239687427e+000;
    __statist_i_h_wts[0,11]=-2.01642408179760e+000;
    __statist_i_h_wts[0,12]=1.18608486993850e+000;
    __statist_i_h_wts[0,13]=1.55132772507209e+000;
    __statist_i_h_wts[0,14]=5.05732170922951e-001;
    __statist_i_h_wts[0,15]=1.45317972675320e+000;
    __statist_i_h_wts[0,16]=1.35579256210656e+000;
    __statist_i_h_wts[0,17]=1.10915091857305e+000;
    __statist_i_h_wts[0,18]=1.66483166943728e+000;

    __statist_i_h_wts[1,0]=-9.29294283308481e+000;
    __statist_i_h_wts[1,1]=-3.31790074895203e+000;
    __statist_i_h_wts[1,2]=-3.49732121675837e+000;
    __statist_i_h_wts[1,3]=1.53337996693594e+000;
    __statist_i_h_wts[1,4]=-2.01373407197507e+000;
    __statist_i_h_wts[1,5]=4.88143547610568e+000;
    __statist_i_h_wts[1,6]=1.05352963959562e+000;
    __statist_i_h_wts[1,7]=4.41560244210490e+000;
    __statist_i_h_wts[1,8]=2.67888125642055e-002;
    __statist_i_h_wts[1,9]=5.50090466322799e-001;
    __statist_i_h_wts[1,10]=2.23110245462794e-001;
    __statist_i_h_wts[1,11]=-2.72727086982348e+000;
    __statist_i_h_wts[1,12]=1.60065444080392e+000;
    __statist_i_h_wts[1,13]=-5.16093156030053e-001;
    __statist_i_h_wts[1,14]=1.43277514780929e+000;
    __statist_i_h_wts[1,15]=-3.59997541625169e-001;
    __statist_i_h_wts[1,16]=-2.96958143606634e-001;
    __statist_i_h_wts[1,17]=7.83606149902228e-001;
    __statist_i_h_wts[1,18]=8.78720284723000e-001;

    __statist_i_h_wts[2,0]=-1.30906277132071e-001;
    __statist_i_h_wts[2,1]=1.17339842410603e-001;
    __statist_i_h_wts[2,2]=1.09811377254601e-001;
    __statist_i_h_wts[2,3]=4.30536928911435e+000;
    __statist_i_h_wts[2,4]=8.90548732777749e-002;
    __statist_i_h_wts[2,5]=3.61834892878804e+000;
    __statist_i_h_wts[2,6]=4.40532692512060e-002;
    __statist_i_h_wts[2,7]=5.82418744242903e-001;
    __statist_i_h_wts[2,8]=7.23443005538282e-003;
    __statist_i_h_wts[2,9]=6.48479979383938e-002;
    __statist_i_h_wts[2,10]=-2.07766361508596e-001;
    __statist_i_h_wts[2,11]=-5.09252651286477e+000;
    __statist_i_h_wts[2,12]=-4.42053845661686e-001;
    __statist_i_h_wts[2,13]=-4.60937147998150e-001;
    __statist_i_h_wts[2,14]=-5.46046620704744e-001;
    __statist_i_h_wts[2,15]=-4.50288651875163e-001;
    __statist_i_h_wts[2,16]=-4.45245762301459e-001;
    __statist_i_h_wts[2,17]=-4.52434982085385e-001;
    __statist_i_h_wts[2,18]=-4.12210222765192e-001;

    __statist_i_h_wts[3,0]=-6.63364881560560e+000;
    __statist_i_h_wts[3,1]=-3.77971787483818e+000;
    __statist_i_h_wts[3,2]=-2.75318075791948e+000;
    __statist_i_h_wts[3,3]=2.09026348585884e+000;
    __statist_i_h_wts[3,4]=-1.19571111953999e+000;
    __statist_i_h_wts[3,5]=3.84490534970698e+000;
    __statist_i_h_wts[3,6]=9.16214127566863e-001;
    __statist_i_h_wts[3,7]=-2.87235398694388e+000;
    __statist_i_h_wts[3,8]=-2.40117549299995e-003;
    __statist_i_h_wts[3,9]=1.97569436550903e+000;
    __statist_i_h_wts[3,10]=8.70887490033343e-001;
    __statist_i_h_wts[3,11]=-9.48378871899877e-001;
    __statist_i_h_wts[3,12]=2.33244754392124e+000;
    __statist_i_h_wts[3,13]=1.12456995700747e+000;
    __statist_i_h_wts[3,14]=9.30018789842343e-001;
    __statist_i_h_wts[3,15]=4.27508001477253e-001;
    __statist_i_h_wts[3,16]=4.63983495606670e-001;
    __statist_i_h_wts[3,17]=-4.92213153442473e-001;
    __statist_i_h_wts[3,18]=1.88132452912771e-001;

    double[,] __statist_h_o_wts = new double[2,4];

    __statist_h_o_wts[0,0]=-3.39608808534406e-001;
    __statist_h_o_wts[0,1]=-1.76085867095260e-001;
    __statist_h_o_wts[0,2]=7.26744060271313e-001;
    __statist_h_o_wts[0,3]=1.30541452809666e-001;

    __statist_h_o_wts[1,0]=-2.98624007791738e-004;
    __statist_h_o_wts[1,1]=-5.76531333528264e-004;
    __statist_h_o_wts[1,2]=6.03276778519446e-004;
    __statist_h_o_wts[1,3]=1.02481711166934e-003;

    double[] __statist_hidden_bias = new double[4];
    __statist_hidden_bias[0]=3.53954040064116e-001;
    __statist_hidden_bias[1]=4.66458677781780e+000;
    __statist_hidden_bias[2]=3.08015520075623e-001;
    __statist_hidden_bias[3]=3.10134910358894e+000;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=4.70266434766697e-001;
    __statist_output_bias[1]=2.65920138597213e-003;

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
