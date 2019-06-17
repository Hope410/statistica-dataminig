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
   public static void __ET_MLP_19_7_2( double[] ContInputs, string[] CatInputs )
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


    double[,] __statist_i_h_wts = new double[7,19];

    __statist_i_h_wts[0,0]=2.28587190486280e+000;
    __statist_i_h_wts[0,1]=2.33412854327169e+000;
    __statist_i_h_wts[0,2]=-7.08946529498621e-002;
    __statist_i_h_wts[0,3]=2.87455414853043e-001;
    __statist_i_h_wts[0,4]=-2.20144014049770e-001;
    __statist_i_h_wts[0,5]=-4.86061863325558e-001;
    __statist_i_h_wts[0,6]=-5.81232169865097e-001;
    __statist_i_h_wts[0,7]=-3.93787705060529e-001;
    __statist_i_h_wts[0,8]=2.63541884532901e-002;
    __statist_i_h_wts[0,9]=-5.82301958614385e-001;
    __statist_i_h_wts[0,10]=-5.33843986076868e-001;
    __statist_i_h_wts[0,11]=-2.50688572194815e-001;
    __statist_i_h_wts[0,12]=3.39705295116703e-001;
    __statist_i_h_wts[0,13]=-1.00767580478751e-001;
    __statist_i_h_wts[0,14]=-3.77625916008712e-002;
    __statist_i_h_wts[0,15]=-1.02186648465425e-001;
    __statist_i_h_wts[0,16]=-1.93471513543800e-001;
    __statist_i_h_wts[0,17]=-6.86206359831858e-001;
    __statist_i_h_wts[0,18]=-4.51737520114388e-001;

    __statist_i_h_wts[1,0]=-4.01954461714847e-001;
    __statist_i_h_wts[1,1]=-4.06016647885671e-001;
    __statist_i_h_wts[1,2]=-5.77111512538627e-001;
    __statist_i_h_wts[1,3]=-7.34108899186925e-001;
    __statist_i_h_wts[1,4]=-4.01328641850277e-001;
    __statist_i_h_wts[1,5]=-3.15726169636113e-001;
    __statist_i_h_wts[1,6]=-2.91436950449206e-001;
    __statist_i_h_wts[1,7]=-2.33893813779237e-001;
    __statist_i_h_wts[1,8]=1.61977200634459e-002;
    __statist_i_h_wts[1,9]=1.34159993069038e+000;
    __statist_i_h_wts[1,10]=-2.67695993196106e-001;
    __statist_i_h_wts[1,11]=2.01065659221522e-001;
    __statist_i_h_wts[1,12]=5.74875247491986e-001;
    __statist_i_h_wts[1,13]=5.05600723527328e-001;
    __statist_i_h_wts[1,14]=2.10420571013047e-001;
    __statist_i_h_wts[1,15]=2.05677057676990e-001;
    __statist_i_h_wts[1,16]=2.14777837055125e-001;
    __statist_i_h_wts[1,17]=1.25806628914292e-001;
    __statist_i_h_wts[1,18]=1.82711792280273e-001;

    __statist_i_h_wts[2,0]=3.25355409760233e+000;
    __statist_i_h_wts[2,1]=9.81585286557576e-003;
    __statist_i_h_wts[2,2]=-1.35430567520147e+000;
    __statist_i_h_wts[2,3]=-1.65635102082709e+000;
    __statist_i_h_wts[2,4]=1.67254756068755e-001;
    __statist_i_h_wts[2,5]=1.61050072979407e-001;
    __statist_i_h_wts[2,6]=1.99723288135265e-001;
    __statist_i_h_wts[2,7]=1.98474414246561e-001;
    __statist_i_h_wts[2,8]=2.60732514578271e-002;
    __statist_i_h_wts[2,9]=8.61365231951513e-001;
    __statist_i_h_wts[2,10]=2.22359853920391e-001;
    __statist_i_h_wts[2,11]=-3.55938601610578e-001;
    __statist_i_h_wts[2,12]=-1.57387160348495e+000;
    __statist_i_h_wts[2,13]=8.11869556121220e-001;
    __statist_i_h_wts[2,14]=2.32091139861306e-001;
    __statist_i_h_wts[2,15]=1.70447278161454e-001;
    __statist_i_h_wts[2,16]=2.33781322918088e-001;
    __statist_i_h_wts[2,17]=3.43342923022096e-002;
    __statist_i_h_wts[2,18]=1.35505085621340e-001;

    __statist_i_h_wts[3,0]=-2.61684208816340e+000;
    __statist_i_h_wts[3,1]=-1.38391040386708e+000;
    __statist_i_h_wts[3,2]=4.89008087715836e-001;
    __statist_i_h_wts[3,3]=1.46857401988305e-001;
    __statist_i_h_wts[3,4]=2.36747375975713e-001;
    __statist_i_h_wts[3,5]=4.62648885621151e-001;
    __statist_i_h_wts[3,6]=5.78214187520808e-001;
    __statist_i_h_wts[3,7]=3.42301468098980e-001;
    __statist_i_h_wts[3,8]=3.34990078851939e-002;
    __statist_i_h_wts[3,9]=-8.21765789025687e-002;
    __statist_i_h_wts[3,10]=4.86344208867507e-002;
    __statist_i_h_wts[3,11]=2.20420148157819e-001;
    __statist_i_h_wts[3,12]=9.84404410171451e-003;
    __statist_i_h_wts[3,13]=-5.12314314778190e-001;
    __statist_i_h_wts[3,14]=-2.09652933449402e-002;
    __statist_i_h_wts[3,15]=-1.13047715552950e-001;
    __statist_i_h_wts[3,16]=-8.95771510962535e-002;
    __statist_i_h_wts[3,17]=6.12943526629170e-001;
    __statist_i_h_wts[3,18]=5.06958538492372e-001;

    __statist_i_h_wts[4,0]=-1.30220747247645e-001;
    __statist_i_h_wts[4,1]=-4.29704515449623e-001;
    __statist_i_h_wts[4,2]=8.24648039178998e-001;
    __statist_i_h_wts[4,3]=6.46163014973137e-001;
    __statist_i_h_wts[4,4]=6.55197061031825e-001;
    __statist_i_h_wts[4,5]=4.30669854908801e-001;
    __statist_i_h_wts[4,6]=4.19709599217537e-001;
    __statist_i_h_wts[4,7]=3.91009780783332e-001;
    __statist_i_h_wts[4,8]=-2.80075946857376e-002;
    __statist_i_h_wts[4,9]=-4.75138187449976e-002;
    __statist_i_h_wts[4,10]=5.28032020956592e-002;
    __statist_i_h_wts[4,11]=-8.15170560414565e-001;
    __statist_i_h_wts[4,12]=-1.57920603053762e+000;
    __statist_i_h_wts[4,13]=1.03145115117369e-001;
    __statist_i_h_wts[4,14]=-2.18888482825601e-001;
    __statist_i_h_wts[4,15]=-4.12556855585788e-001;
    __statist_i_h_wts[4,16]=-3.83345086015270e-001;
    __statist_i_h_wts[4,17]=3.68372855502669e-002;
    __statist_i_h_wts[4,18]=-6.10434591741074e-002;

    __statist_i_h_wts[5,0]=3.41765585363228e-001;
    __statist_i_h_wts[5,1]=6.13780384621007e-001;
    __statist_i_h_wts[5,2]=8.75795964647814e-002;
    __statist_i_h_wts[5,3]=1.57981931938223e-001;
    __statist_i_h_wts[5,4]=5.13737579017650e-001;
    __statist_i_h_wts[5,5]=2.67996803622708e-001;
    __statist_i_h_wts[5,6]=2.84973536696096e-001;
    __statist_i_h_wts[5,7]=1.07101573890716e-001;
    __statist_i_h_wts[5,8]=1.55704242740946e-002;
    __statist_i_h_wts[5,9]=-2.03486345205806e+000;
    __statist_i_h_wts[5,10]=4.52273986629994e-001;
    __statist_i_h_wts[5,11]=1.63200471177298e-001;
    __statist_i_h_wts[5,12]=1.50769998268037e-001;
    __statist_i_h_wts[5,13]=-3.82545799104498e-001;
    __statist_i_h_wts[5,14]=-7.76875004390778e-002;
    __statist_i_h_wts[5,15]=-2.25217661634206e-001;
    __statist_i_h_wts[5,16]=-2.39132960506372e-001;
    __statist_i_h_wts[5,17]=1.01447687521469e-001;
    __statist_i_h_wts[5,18]=6.47704206669370e-002;

    __statist_i_h_wts[6,0]=-6.69459327755551e-001;
    __statist_i_h_wts[6,1]=-3.23958953607517e+000;
    __statist_i_h_wts[6,2]=1.86685749958598e-001;
    __statist_i_h_wts[6,3]=2.87129468997740e-001;
    __statist_i_h_wts[6,4]=-2.79879814846501e-001;
    __statist_i_h_wts[6,5]=-4.16599171868511e-001;
    __statist_i_h_wts[6,6]=-5.12666061609398e-001;
    __statist_i_h_wts[6,7]=-5.81298535079697e-001;
    __statist_i_h_wts[6,8]=1.75158129955050e-003;
    __statist_i_h_wts[6,9]=-9.15093669858843e-001;
    __statist_i_h_wts[6,10]=2.22673873597902e+000;
    __statist_i_h_wts[6,11]=3.69517833786857e-001;
    __statist_i_h_wts[6,12]=2.41151004332250e-002;
    __statist_i_h_wts[6,13]=4.27206793662397e-001;
    __statist_i_h_wts[6,14]=3.87343424506349e-001;
    __statist_i_h_wts[6,15]=5.15034924794944e-001;
    __statist_i_h_wts[6,16]=5.44290068560956e-001;
    __statist_i_h_wts[6,17]=6.10686331704700e-001;
    __statist_i_h_wts[6,18]=5.91395860450503e-001;

    double[,] __statist_h_o_wts = new double[2,7];

    __statist_h_o_wts[0,0]=-8.80913451956684e-001;
    __statist_h_o_wts[0,1]=-7.66713176877211e-001;
    __statist_h_o_wts[0,2]=-3.26338022524288e-001;
    __statist_h_o_wts[0,3]=-7.68890832846622e-001;
    __statist_h_o_wts[0,4]=1.58039186984688e-001;
    __statist_h_o_wts[0,5]=9.19368547571327e-002;
    __statist_h_o_wts[0,6]=-6.40550788859454e-001;

    __statist_h_o_wts[1,0]=6.00806615581038e-003;
    __statist_h_o_wts[1,1]=1.18797423524220e-003;
    __statist_h_o_wts[1,2]=3.26019075932801e-003;
    __statist_h_o_wts[1,3]=6.68318448761232e-003;
    __statist_h_o_wts[1,4]=8.72335689854431e-004;
    __statist_h_o_wts[1,5]=-7.70845106051675e-004;
    __statist_h_o_wts[1,6]=7.47413992188065e-004;

    double[] __statist_hidden_bias = new double[7];
    __statist_hidden_bias[0]=-1.46300986465893e+000;
    __statist_hidden_bias[1]=4.66655253598551e-001;
    __statist_hidden_bias[2]=-1.51932539970157e+000;
    __statist_hidden_bias[3]=1.48613536440826e+000;
    __statist_hidden_bias[4]=-2.37608756153089e-001;
    __statist_hidden_bias[5]=4.51888694166452e-002;
    __statist_hidden_bias[6]=1.58919060042777e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=4.62159387380336e-001;
    __statist_output_bias[1]=3.55757497109150e-003;

    double[] __statist_inputs = new double[19];

    double[] __statist_hidden = new double[7];

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
    int __statist_nhidden=7;

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
     __ET_MLP_19_7_2( ContInputs, CatInputs );
   }

}
