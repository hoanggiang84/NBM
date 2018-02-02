using System.Runtime.InteropServices;

namespace SAM.Core.Nscope
{
    public class niScope : object, System.IDisposable
    {

        private System.IntPtr _handle;

        private bool _disposed = true;

        ~niScope() { Dispose(false); }


        /// <summary>
        /// Performs the following initialization actions:
        /// 
        /// - Creates a new IVI instrument driver session 
        /// - Opens a session to the specific driver using the interface and address you specify in the resourceName parameter 
        /// - Queries the instrument ID and checks that it is valid for this instrument driver, if the IDQuery parameter is set to NISCOPE_VAL_TRUE 
        /// - Resets the digitizer to a known state, if the resetDevice parameter is set to NISCOPE_VAL_TRUE
        /// - Sends initialization commands to set the instrument to the state necessary for the operation of the instrument driver 
        /// - Returns an instrument handle that you use to identify the instrument in all subsequent instrument driver function calls
        /// 
        /// </summary>
        /// <param name="Resource_Name">
        /// Specifies the resource name of the device to initialize.
        /// 
        /// Example Device Type Syntax 
        /// 1 Traditional NI-DAQ device DAQ::1 (1 = device number)
        /// 2 NI-DAQmx device myDAQmxDevice (myDAQmxDevice = device name) 
        /// 3 NI-DAQmx device DAQ::myDAQmxDevice myDAQmxDevice = device name)
        /// 4 NI-DAQmx device DAQ::2 (2 = device name)
        /// 5 IVI logical name or IVI virtual name myLogicalName          (myLogicalName = name)
        /// 
        /// 
        /// For Traditional NI-DAQ devices, the syntax is DAQ::n, where n is the device number assigned by MAX, as shown in Example 1. 
        /// 
        /// For NI-DAQmx devices, the syntax is just the device name specified in MAX, as shown in Example 2. Typical default names for NI-DAQmx devices in MAX are Dev1 or PXI1Slot1. You can rename an NI-DAQmx device by right-clicking on the name in MAX and entering a new name. 
        /// 
        /// An alternative syntax for NI-DAQmx devices consists of DAQ::NI-DAQmx device name, as shown in Example 3. This naming convention allows for the use of an NI-DAQmx device in an application that was originally designed for a Traditional NI-DAQ device. For example, if the application expects DAQ::1, you can rename the NI-DAQmx device to 1 in MAX and pass in DAQ::1 for the resource name, as shown in Example 4. 
        /// 
        /// If you use the DAQ::n syntax and an NI-DAQmx device name already exists with that same name, the NI-DAQmx device is matched first. 
        /// 
        /// You can also pass in the name of an IVI logical name or an IVI virtual name configured with the IVI Configuration utility, as shown in Example 5. A logical name identifies a particular virtual instrument. A virtual name identifies a specific device and specifies the initial settings for the session. 
        /// 
        ///  Caution  Traditional NI-DAQ and NI-DAQmx device names are not case-sensitive. However, all IVI names, such as logical names, are case-sensitive. If you use logical names, driver session names, or virtual names in your program, you must make sure that the name you use matches the name in the IVI Configuration Store file exactly, without any variations in the case of the characters.  
        /// 
        /// </param>
        /// <param name="ID_Query">
        /// Specifies whether you want the instrument driver to perform an ID Query. When you set this parameter to TRUE, NI-SCOPE verifies that the instrument you initialize is a type that this driver supports. 
        ///  
        /// Defined Values
        /// 
        /// VI_TRUE (1)-- Perform ID Query 
        /// 
        /// VI_FALSE (0)-- Skip ID Query
        /// 
        /// 
        /// </param>
        /// <param name="Reset_Device">
        /// Specifies whether to reset the instrument during the initialization process. 
        /// 
        /// Defined Values
        /// 
        /// VI_TRUE (1)- Reset device
        /// 
        /// VI_FALSE (0)- Do not reset device
        /// 
        /// Default Value: VI_TRUE (1)
        /// 
        /// 
        /// 
        /// </param>
        /// <param name="Instrument_Handle">
        /// Returns a ViSession handle that you use to identify the instrument in all subsequent instrument driver function calls.
        /// </param>
        public niScope(string Resource_Name, bool ID_Query, bool Reset_Device)
        {
            int pInvokeResult = PInvoke.init(Resource_Name, System.Convert.ToUInt16(ID_Query), System.Convert.ToUInt16(Reset_Device), out this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            this._disposed = false;
        }

        /// <summary>
        /// Performs the following initialization actions:
        /// 
        /// - Creates a new IVI instrument driver and optionally sets the initial state of the following session properties: Range Check, Cache, Simulate, Record Value Coercions 
        /// - Opens a session to the specified device using the interface and address you specify for the Resource Name parameter 
        /// - Resets the digitizer to a known state if the resetDevice parameter is set to VI_TRUE
        /// - Queries the instrument ID and verifies that it is valid for this instrument driver if the IDQuery parameter is set to VI_TRUE 
        /// - Returns an instrument handle that you use to identify the instrument in all subsequent instrument driver function calls 
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="Resource_Name">
        /// Specifies the resource name of the device to initialize.
        /// 
        /// Example Device Type Syntax 
        /// 1 Traditional NI-DAQ device DAQ::1 (1 = device number)
        /// 2 NI-DAQmx device myDAQmxDevice (myDAQmxDevice = device name) 
        /// 3 NI-DAQmx device DAQ::myDAQmxDevice myDAQmxDevice = device name)
        /// 4 NI-DAQmx device DAQ::2 (2 = device name)
        /// 5 IVI logical name or IVI virtual name myLogicalName          (myLogicalName = name)
        /// 
        /// For Traditional NI-DAQ devices, the syntax is DAQ::n, where n is the device number assigned by MAX, as shown in Example 1. 
        /// 
        /// For NI-DAQmx devices, the syntax is just the device name specified in MAX, as shown in Example 2. Typical default names for NI-DAQmx devices in MAX are Dev1 or PXI1Slot1. You can rename an NI-DAQmx device by right-clicking on the name in MAX and entering a new name. 
        /// 
        /// An alternatative syntax for NI-DAQmx devices consists of DAQ::NI-DAQmx device name, as shown in Example 3. This naming convention allows for the use of an NI-DAQmx device in an application that was originally designed for a Traditional NI-DAQ device. For example, if the application expects DAQ::1, you can rename the NI-DAQmx device to 1 in MAX and pass in DAQ::1 for the resource name, as shown in Example 4. 
        /// 
        /// If you use the DAQ::n syntax and an NI-DAQmx device name already exists with that same name, the NI-DAQmx device is matched first. 
        /// 
        /// You can also pass in the name of an IVI logical name or an IVI virtual name configured with the IVI Configuration utility, as shown in Example 5. A logical name identifies a particular virtual instrument. A virtual name identifies a specific device and specifies the initial settings for the session. 
        /// 
        ///  Caution  Traditional NI-DAQ and NI-DAQmx device names are not case-sensitive. However, all IVI names, such as logical names, are case-sensitive. If you use logical names, driver session names, or virtual names in your program, you must make sure that the name you use matches the name in the IVI Configuration Store file exactly, without any variations in the case of the characters.  
        /// 
        /// </param>
        /// <param name="ID_Query">
        /// Specifies whether you want the instrument driver to perform an ID Query.
        /// Valid Values
        /// 
        /// VI_TRUE (1)- Perform ID Query 
        /// 
        /// VI_FALSE (0)- Skip ID Query
        /// 
        /// Default Value: VI_FALSE
        /// 
        /// When you set this parameter to NISCOPE_VAL_TRUE, NI-SCOPE verifies that the instrument you initialize is a type that this driver supports.
        /// 
        /// </param>
        /// <param name="Reset_Device">
        /// Specifies whether you want the to reset the digitizer to a known state during the initialization procedure.
        /// 
        /// Valid Range:
        /// NISCOPE_VAL_TRUE  (1) - Reset Scope
        /// NISCOPE_VAL_FALSE (0) - Don't Reset Scope
        /// 
        /// Default Value:
        /// NISCOPE_VAL_TRUE (1)
        /// 
        /// </param>
        /// <param name="Option_String">
        /// Specifies initialization commands. The following table lists the attributes and the name you use in the option string parameter to identify the attribute.
        /// 
        /// Attribute Name Attribute Values 
        /// RangeCheck - NISCOPE_ATTR_RANGE_CHECK VI_TRUE, VI_FALSE 
        /// QueryInstrStatus - NISCOPE_QUERY_INSTRUMENT_STATUS VI_TRUE, VI_FALSE  
        /// Cache - NISCOPE_ATTR_CACHE VI_TRUE, VI_FALSE 
        /// Simulate - NISCOPE_ATTR_SIMULATE VI_TRUE, VI_FALSE  
        /// 
        /// Default Values: "Simulate=0,RangeCheck=1,QueryInstrStatus=1,Cache=1"
        /// 
        /// You can use the option string to simulate a device. The DriverSetup flag specifies the model that is to be simulated and the type of the model. One example to simulate an NI PXI-5102 would be as follows:
        /// 
        /// Option String: Simulate = 1, DriverSetup = Model:5102; BoardType:PXI
        /// 
        /// Refer to the example niScope EX Simulated Acquisition for more information on simulation.
        /// 
        ///  Caution  All IVI names, such as logical names or virtual names, are case-sensitive. If you use logical names, driver session names, or virtual names in your program, you must make sure that the name you use matches the name in the IVI Configuration Store file exactly, without any variations in the case of the characters in the name.  
        /// 
        /// Default Value: "Simulate=0,RangeCheck=1,Cache=1"
        /// 
        /// 
        /// </param>
        /// <param name="Instrument_Handle">
        /// Returns a ViSession handle that you use to identify the instrument in all subsequent instrument driver function calls.
        /// </param>
        public niScope(string Resource_Name, bool ID_Query, bool Reset_Device, string Option_String)
        {
            int pInvokeResult = PInvoke.InitWithOptions(Resource_Name, System.Convert.ToUInt16(ID_Query), System.Convert.ToUInt16(Reset_Device), Option_String, out this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            this._disposed = false;
        }

        /// <summary>
        /// Automatically configures the instrument. When you call this function, the digitizer senses the input signal and automatically configures many of the instrument settings. If no signal is found on any analog input channel, a warning is returned, and all channels are enabled. A channel is considered to have a signal present if the signal is at least 10% of the smallest vertical range available for that channel. 
        /// 
        /// 
        /// The following settings are changed:
        /// 
        /// General
        /// Acquisition mode      Normal
        /// Reference Clock       Internal
        /// 
        /// Vertical
        /// Vertical Coupling     AC ((DC for NI 5620/5621)
        /// Vertical Bandwidth    Full
        /// Vertical Range        Changed by Auto Setup
        /// Vertical Offset       0 V
        /// Probe Attenuation     Unchanged by Auto Setup
        /// Input Impedance       Unchanged by Auto Setup
        /// 
        /// Horizontal
        /// Sample Rate           Changed by Auto Setup
        /// Min Record Length     Changed by Auto Setup
        /// Enforce Realtime      True
        /// Number of Records     Changed to 1
        /// 
        /// Triggering
        /// Trigger Mode          Edge if signal present, otherwise Immediate
        /// Trigger Channel       Lowest numbered channel with a signal present
        /// Trigger Slope         Positive
        /// Trigger Coupling      DC
        /// Reference Position    50%
        /// Trigger Level         50% of signal on trigger channel
        /// Trigger Delay         0
        /// Trigger Holdoff       0
        /// Trigger Output        None
        ///  
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int AutoSetup()
        {
            int pInvokeResult = PInvoke.AutoSetup(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures how the digitizer acquires data and fills the waveform record.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Acquisition_Type">
        /// Specifies the manner in which the digitizer acquires data and fills the waveform record; NI-SCOPE sets the NISCOPE_ATTR_ACQUISITION_TYPE attribute to this value.
        /// 
        /// Defined Values
        /// 
        /// NISCOPE_VAL_NORMAL 
        /// 
        /// NISCOPE_VAL_FLEXRES 
        /// 
        /// NISCOPE_VAL_DDC
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureAcquisition(int Acquisition_Type)
        {
            int pInvokeResult = PInvoke.ConfigureAcquisition(this._handle, Acquisition_Type);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the common properties of the horizontal subsystem for a multi-record acquisition in terms of minimum sample rate. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Min_Sample_Rate">
        /// The sampling rate for the acquisition; NI-SCOPE uses this value to set  NISCOPE_ATTR_MIN_SAMPLE_RATE.
        /// </param>
        /// <param name="Min_Num_Pts">
        /// The minimum number of points you need in the record for each channel; call niScope_ActualRecordLength to obtain the actual record length used.
        /// 
        /// Valid Values 
        /// Greater than 1; limited by available memory
        /// 
        /// 
        /// </param>
        /// <param name="Ref_Position">
        /// The position of the Reference Event in the waveform record specified as a percentage.
        /// </param>
        /// <param name="Num_Records">
        /// The number of records to acquire.
        /// </param>
        /// <param name="Enforce_Realtime">
        /// Indicates whether the digitizer enforces real-time measurements or allows equivalent-time measurements.
        /// 
        /// Default Value: NISCOPE_VAL_TRUE (1)
        /// 
        /// Valid Range:
        /// VI_TRUE (1) - Allow real-time acquisitions only
        /// VI_FALSE (0) - Allow real-time and equivalent-time acquisitions
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureHorizontalTiming(double Min_Sample_Rate, int Min_Num_Pts, double Ref_Position, int Num_Records, bool Enforce_Realtime)
        {
            int pInvokeResult = PInvoke.ConfigureHorizontalTiming(this._handle, Min_Sample_Rate, Min_Num_Pts, Ref_Position, Num_Records, System.Convert.ToUInt16(Enforce_Realtime));
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the attributes that control the electrical characteristics of the channel: the input impedance and the bandwidth.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// Name of the channel you want to configure.
        /// 
        /// </param>
        /// <param name="Input_Impedance">
        /// The input impedance for the channel; NI-SCOPE sets NISCOPE_ATTR_INPUT_IMPEDANCE to this value. 
        /// 
        /// </param>
        /// <param name="Max_Input_Frequency">
        /// The bandwidth for the channel; NI-SCOPE sets  NISCOPE_ATTR_MAX_INPUT_FREQUENCY to this value.
        /// 
        /// Passing 0 for this value uses the default bandwidth of the hardware.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureChanCharacteristics(string Channel_List, double Input_Impedance, double Max_Input_Frequency)
        {
            int pInvokeResult = PInvoke.ConfigureChanCharacteristics(this._handle, Channel_List, Input_Impedance, Max_Input_Frequency);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the most commonly configured attributes of the digitizer vertical subsystem, such as the range, offset, coupling, probe attenuation, and the channel.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The name of the digitizer channel to configure.
        /// 
        /// Valid Values: 
        /// "0".."n-1",  n is the number of channels on the NI-SCOPE digitizer.
        /// 
        /// </param>
        /// <param name="Range">
        /// Specifies the vertical range; NI-SCOPE uses this value to set NISCOPE_ATTR_VERTICAL_RANGE.
        /// </param>
        /// <param name="Offset">
        /// Specifies the vertical offset; NI-SCOPE uses this value to set NISCOPE_ATTR_VERTICAL_OFFSET.
        /// </param>
        /// <param name="Coupling">
        /// Specifies how to couple the input signal; NI-SCOPE uses this value to set NISCOPE_ATTR_VERTICAL_COUPLING.
        /// </param>
        /// <param name="Probe_Attenuation">
        /// Specifies the probe attenuation; NI-SCOPE uses this value to set  NISCOPE_ATTR_PROBE_ATTENUATION.
        /// </param>
        /// <param name="Enabled">
        /// Specifies whether the channel is enabled for acquisition; NI-SCOPE uses this value to set NISCOPE_ATTR_CHANNEL_ENABLED.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureVertical(string Channel_List, double Range, double Offset, int Coupling, double Probe_Attenuation, bool Enabled)
        {
            int pInvokeResult = PInvoke.ConfigureVertical(this._handle, Channel_List, Range, Offset, Coupling, Probe_Attenuation, System.Convert.ToUInt16(Enabled));
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the actual number of points the digitizer acquires for each channel. After configuring the digitizer for an acquisition, call this function to determine the size of the waveforms that the digitizer acquires. The value is equal to or greater than the minimum number of points specified in any of the Configure Horizontal functions.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Record_Length">
        /// Returns the actual number of points the digitizer acquires for each channel; NI-SCOPE returns the value held in NISCOPE_ATTR_HORZ_RECORD_LENGTH.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ActualRecordLength(out int Record_Length)
        {
            int pInvokeResult = PInvoke.ActualRecordLength(this._handle, out Record_Length);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Allows you to declare appropriately-sized waveforms. NI-SCOPE handles the channel list parsing for you. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel to acquire data from; it may be a single channel, such as "0" or "1",  or a list of channels, such as "0,1".
        /// </param>
        /// <param name="Num_Wfms">
        /// Returns the number of records times the number of channels; if you are operating in DDC mode (NI 5620/5621 only), this value is  multiplied by two.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ActualNumWfms(string Channel_List, out int Num_Wfms)
        {
            int pInvokeResult = PInvoke.ActualNumWfms(this._handle, Channel_List, out Num_Wfms);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the total available size of an array measurement acquisition. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Array_Meas_Function">
        /// The measurement to be performed on the waveform. 
        /// 
        /// Refer to the Array Measurements topic in the NI-SCOPE Function Reference Help for a list of defined values.
        /// </param>
        /// <param name="Meas_Waveform_Size">
        /// Returns the size (in number of samples) of the resulting analysis waveform.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ActualMeasWfmSize(int Array_Meas_Function, out int Meas_Waveform_Size)
        {
            int pInvokeResult = PInvoke.ActualMeasWfmSize(this._handle, Array_Meas_Function, out Meas_Waveform_Size);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the sample mode the digitizer is currently using. 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Sample_Mode">
        /// The sample mode the digitizer is currently using. NI-SCOPE returns the value in  NISCOPE_ATTR_SAMPLE_MODE.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int SampleMode(out int Sample_Mode)
        {
            int pInvokeResult = PInvoke.SampleMode(this._handle, out Sample_Mode);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the effective sample rate of the acquired waveform using the current configuration in samples per second.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Sample_Rate">
        /// Returns the effective sample rate of the acquired waveform the digitizer acquires for each channel; the driver returns the value held in NISCOPE_ATTR_HORZ_SAMPLE_RATE.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int SampleRate(out double Sample_Rate)
        {
            int pInvokeResult = PInvoke.SampleRate(this._handle, out Sample_Rate);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the common properties of a digital trigger. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Source">
        /// Pass the source you want the digitizer to monitor for a trigger.  
        /// 
        /// Valid Values: 
        /// 
        /// NISCOPE_VAL_RTSI_0             - RTSI 0
        /// NISCOPE_VAL_RTSI_1             - RTSI 1
        /// NISCOPE_VAL_RTSI_2             - RTSI 2
        /// NISCOPE_VAL_RTSI_3             - RTSI 3
        /// NISCOPE_VAL_RTSI_4             - RTSI 4
        /// NISCOPE_VAL_RTSI_5             - RTSI 5
        /// NISCOPE_VAL_RTSI_6             - RTSI 6
        /// NISCOPE_VAL_PFI_0              - PFI 0
        /// NISCOPE_VAL_PFI_1              - PFI 1
        /// NISCOPE_VAL_PFI_2              - PFI 2
        /// NISCOPE_VAL_PXI_STAR           - PXI Star Trigger
        /// </param>
        /// <param name="Slope">
        /// Specifies whether you want a rising edge or a falling edge to trigger the digitizer. Refer to NISCOPE_ATTR_TRIGGER_SLOPE for the defined values.
        /// </param>
        /// <param name="Holdoff">
        /// The length of time the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger; the units are seconds; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_HOLDOFF.
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerDigital(string Trigger_Source, int Slope, double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerDigital(this._handle, Trigger_Source, Slope, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures common properties for analog edge triggering. An edge trigger occurs when the trigger signal passes through the voltage threshold that you specify with the Trigger Level parameter and has the slope that you specify with the Trigger Slope parameter.  
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Source">
        /// The trigger source; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_SOURCE.
        /// </param>
        /// <param name="Level">
        /// The voltage threshold for the trigger; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_LEVEL.
        /// </param>
        /// <param name="Slope">
        /// Specifies whether you want a rising edge or a falling edge to trigger the digitizer Refer to NISCOPE_ATTR_TRIGGER_SLOPE for the defined values.
        /// </param>
        /// <param name="Trigger_Coupling">
        /// Applies coupling and filtering options to the trigger signal; NI-SCOPE uses this value to set  NISCOPE_ATTR_TRIGGER_COUPLING. 
        /// </param>
        /// <param name="Holdoff">
        /// The length of time the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger; the units are seconds; NI-SCOPE uses this value to set  NISCOPE_ATTR_TRIGGER_HOLDOFF.
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerEdge(string Trigger_Source, double Level, int Slope, int Trigger_Coupling, double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerEdge(this._handle, Trigger_Source, Level, Slope, Trigger_Coupling, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the common properties for video triggering, including the signal format, TV event, line number, polarity, and enable DC restore. A video trigger occurs when the digitizer finds a valid video signal sync. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Source">
        /// The trigger source; valid trigger sources vary depending on your digitizer.
        /// </param>
        /// <param name="Enable_DC_Restore">
        /// Offsets each video line so the clamping level (the portion of the video line between the end of the color burst and the beginning of the active image) is moved to zero volt.
        /// </param>
        /// <param name="Signal_Format">
        /// Specifies the type of video signal sync the digitizer should look for.
        /// </param>
        /// <param name="Event">
        /// Specifies the TV event you want to trigger on. You can trigger on a specific or on the next coming line or field of the signal.
        /// </param>
        /// <param name="Line_Number">
        /// Selects the line number to trigger on. 
        /// 
        /// Default Value: 1
        /// </param>
        /// <param name="Polarity">
        /// Specifies the polarity of the video signal sync, either positive or negative.
        /// </param>
        /// <param name="Trigger_Coupling">
        /// Specifies how you want the digitizer to couple the trigger signal; refer to NISCOPE_ATTR_TRIGGER_COUPLING for defined values.
        ///   
        /// 
        /// </param>
        /// <param name="Holdoff">
        /// Specifies the length of time the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_HOLDOFF.Use the trigger holdoff to skip a specific number of frames between acquisitions. For example, to acquire a specific line number multiple times and repeat the same chroma phase, skip 1 frame in NTSC (35 ms &lt; holdoff &lt; 60 ms), 3 frames in PAL (121 ms &lt; holdoff &lt; 159 ms) and 5 frames in SECAM (201 ms &lt; holdoff &lt; 239 ms). 
        /// 
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerVideo(string Trigger_Source, bool Enable_DC_Restore, int Signal_Format, int Event, int Line_Number, int Polarity, int Trigger_Coupling, double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerVideo(this._handle, Trigger_Source, System.Convert.ToUInt16(Enable_DC_Restore), Signal_Format, Event, Line_Number, Polarity, Trigger_Coupling, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures common properties for analog hysteresis triggering. This kind of trigger adds another value, specified in the hysteresis parameter, that a signal must pass through before a trigger can occur. This additional value acts as a kind of buffer zone that keeps noise from triggering an acquisition. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Source">
        /// The source you want the digitizer to monitor for a trigger.  
        /// 
        /// 
        /// </param>
        /// <param name="Level">
        /// The voltage threshold for the trigger; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_LEVEL.
        /// 
        /// </param>
        /// <param name="Hysteresis">
        /// The size of the hysteresis window on either side of the level in volts; the digitizer triggers when the trigger signal passes through the hysteresis value you specify with this parameter, has the slope you specify with slope, and passes through the level Refer to NISCOPE_ATTR_TRIGGER_HYSTERESIS for valid values.
        /// </param>
        /// <param name="Slope">
        /// Specifies whether you want a rising edge or a falling edge to trigger the digitizer Refer to NISCOPE_ATTR_TRIGGER_SLOPE for the defined values.
        /// </param>
        /// <param name="Trigger_Coupling">
        /// Applies coupling and filtering options to the trigger signal; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_COUPLING.
        /// 
        /// </param>
        /// <param name="Holdoff">
        /// The length of time the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger; the units are in seconds; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_HOLDOFF.
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerHysteresis(string Trigger_Source, double Level, double Hysteresis, int Slope, int Trigger_Coupling, double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerHysteresis(this._handle, Trigger_Source, Level, Hysteresis, Slope, Trigger_Coupling, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures common properties for immediate triggering. Immediate triggering means the digitizer triggers itself. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for a trigger. You specify the type of trigger that the digitizer waits for with a Configure Trigger function such as  this one. 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerImmediate()
        {
            int pInvokeResult = PInvoke.ConfigureTriggerImmediate(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures common properties for software triggering. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Holdoff">
        /// The length of time the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger; the units are seconds; NI-SCOPE uses this value to set  NISCOPE_ATTR_TRIGGER_HOLDOFF.
        /// 
        /// 
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerSoftware(double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerSoftware(this._handle, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures common properties for analog window triggering. A window trigger occurs when a signal enters or leaves a window you specify with the high level or low level parameters. 
        /// 
        /// When you initiate an acquisition, the digitizer waits for the start trigger, which is configured through the NISCOPE_ATTR_ACQ_ARM_SOURCE (Start Trigger Source) attribute. The default is immediate. Upon receiving the start trigger the digitizer begins sampling pretrigger points. After the digitizer finishes sampling pretrigger points, the digitizer waits for a reference (stop) trigger that you specify with a function such as this one. Upon receiving the reference trigger the digitizer finishes the acquisition after completing posttrigger sampling. With each Configure Trigger function, you specify configuration parameters such as the trigger source and the amount of trigger delay. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Source">
        /// The source you want the digitizer to monitor for a trigger. Refer to NISCOPE_ATTR_TRIGGER_SOURCE for more information. 
        /// 
        /// 
        /// </param>
        /// <param name="Low_Level">
        /// The voltage threshold you want the digitizer to use for low triggering. Refer to NISCOPE_ATTR_TRIGGER_WINDOW_LOW_LEVEL for more information.
        /// </param>
        /// <param name="High_Level">
        /// the voltage threshold you want the digitizer to use for high triggering; refer to NISCOPE_ATTR_TRIGGER_WINDOW_HIGH_LEVEL for more information.
        /// </param>
        /// <param name="Window_Mode">
        /// Specifies whether you want the trigger to occur when the signal enters or leaves a window. Refer to  NISCOPE_ATTR_TRIGGER_WINDOW_MODE for more information.
        /// </param>
        /// <param name="Trigger_Coupling">
        /// Applies coupling and filtering options to the trigger signal; NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_COUPLING. 
        /// 
        /// </param>
        /// <param name="Holdoff">
        /// The length of time (in seconds)  the digitizer waits after detecting a trigger before enabling NI-SCOPE to detect another trigger. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_HOLDOFF.
        /// </param>
        /// <param name="Delay">
        /// The length of time (in seconds) the digitizer waits after it receives the trigger to start acquiring data. NI-SCOPE uses this value to set NISCOPE_ATTR_TRIGGER_DELAY_TIME. 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerWindow(string Trigger_Source, double Low_Level, double High_Level, int Window_Mode, int Trigger_Coupling, double Holdoff, double Delay)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerWindow(this._handle, Trigger_Source, Low_Level, High_Level, Window_Mode, Trigger_Coupling, Holdoff, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Sends the selected trigger to the digitizer. Call this function if you called niScope_ConfigureTriggerSoftware when you want the Reference trigger to occur. You can also call this function to override a misused edge, digital, or hysteresis trigger. If you have configured NISCOPE_ATTR_ACQ_ARM_SOURCE,  NISCOPE_ATTR_ARM_REF_TRIG_SRC, or  NISCOPE_ATTR_ADV_TRIG_SRC, call this function when you want to send the corresponding trigger to the digitizer.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Which_Trigger">
        /// The type of trigger to send to the digitizer.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int SendSoftwareTriggerEdge(int Which_Trigger)
        {
            int pInvokeResult = PInvoke.SendSoftwareTriggerEdge(this._handle, Which_Trigger);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the relative sample clock delay. Each time this function is called, the sample clock is delayed by the specified amount of time in seconds.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Delay">
        /// The amount of time in seconds to delay the sample clock. Delay is a relative value, so repeated calls to this function  delays the sample clock by this amount every time.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int AdjustSampleClockRelativeDelay(double Delay)
        {
            int pInvokeResult = PInvoke.AdjustSampleClockRelativeDelay(this._handle, Delay);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the attributes for synchronizing the digitizer to a reference or sending the digitizer's reference clock output to be used as a synchronizing clock for other devices.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Input_Clock_Source">
        /// Specifies the input source for the reference clock to which the 100 MHz sample clock is phase-locked. Refer to NISCOPE_ATTR_INPUT_CLOCK_SOURCE for more information. 
        /// </param>
        /// <param name="Output_Clock_Source">
        /// Specifies the output source for the reference clock to which the sample clock of another digitizer can be phased-locked. Refer to NISCOPE_ATTR_OUTPUT_CLOCK_SOURCE for more information.
        /// </param>
        /// <param name="Clock_Sync_Pulse_Source">
        /// For the NI 5102, specifies the line on which the sample clock is sent or received. For all other NI digitizers, specifies the line on which the one-time sync pulse is sent or received. This line should be the same for all devices to be synchronized. Refer to NISCOPE_ATTR_CLOCK_SYNC_PULSE_SOURCE for more information and for defined values.
        /// </param>
        /// <param name="Master_Enabled">
        /// Specifies whether you want the device to be a master or a slave. The master device is typically the originator of the trigger signal and clock sync pulse. For a standalone device, set this attribute to VI_FALSE. 
        /// 
        /// Refer to NISCOPE_ATTR_MASTER_ENABLE for more information.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureClock(string Input_Clock_Source, string Output_Clock_Source, string Clock_Sync_Pulse_Source, bool Master_Enabled)
        {
            int pInvokeResult = PInvoke.ConfigureClock(this._handle, Input_Clock_Source, Output_Clock_Source, Clock_Sync_Pulse_Source, System.Convert.ToUInt16(Master_Enabled));
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the digitizer to generate a signal pulse that other devices can detect when configured for digital triggering.  
        /// 
        /// Note    For Traditional NI-DAQ devices, exported signals are still present in the route after the session is closed. You must clear the route before closing the session, or call niScope_reset. 
        /// 
        /// To clear the route, call this function again and route NISCOPE_VAL_NONE to the line that you had exported. 
        /// For example, if you originally called this function with the trigger event NISCOPE_VAL_STOP_TRIGGER_EVENT routed to the trigger output NISCOPE_VAL_RTSI_0, you would call this function again with NISCOPE_VAL_NONE routed to NISCOPE_VAL_RTSI_0 to clear the route.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Event">
        /// Specifies the condition in which this device will generate a digital pulse. .
        /// 
        /// Valid Values
        /// 
        /// NISCOPE_VAL_NO_EVENT
        /// 
        /// NISCOPE_VAL_STOP_TRIGGER_EVENT 
        /// 
        /// NISCOPE_VAL_START_TRIGGER_EVENT 
        /// 
        /// NISCOPE_VAL_END_OF_ACQUISITION_EVENT 
        /// 
        /// NISCOPE_VAL_END_OF_RECORD_EVENT 
        /// 
        /// </param>
        /// <param name="Trigger_Output">
        /// Specifies the hardware signal line on which the digital pulse will be generated. Refer to NISCOPE_ATTR_TRIGGER_OUTPUT_SOURCE  for more information
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerOutput(int Trigger_Event, string Trigger_Output)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerOutput(this._handle, Trigger_Event, Trigger_Output);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the digitizer to generate a signal that other devices can detect when configured for digital triggering or sharing clocks. The signal parameter specifies what condition causes the digitizer to generate the signal. The outputTerminal parameter specifies where to send the signal on the hardware (such as a PFI connector or RTSI line). 
        /// 
        /// In cases where multiple instances of a particular signal exist, use the signalIdentifier input to specify which instance to control. For normal signals, only one instance exists and you should leave this parameter set to the empty string. You can call this function multiple times and set each available line to a different signal.
        /// 
        /// To unprogram a specific line on device, call this function with the signal you no longer want to export and set outputTerminal to None.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Signal">
        /// Signal (clock, trigger, or event) to export. 
        /// Defined Values
        /// 
        /// Reference Trigger (1) Generate a pulse when detecting the Stop/Reference trigger.  
        /// Start Trigger  (2) Generate a pulse when detecting a Start trigger. 
        /// End of Acquisition Event  (3) Generate a pulse when the acquisition finishes. 
        /// End of Record Event  (4) Generate a pulse at the end of the record. 
        /// Advance Trigger  (5) Generate a pulse when detecting an Advance trigger. 
        /// Ready for Advance Event  (6) Asserts when the digitizer is ready to advance to the next record. 
        /// Ready for Start Event  (7) Asserts when the digitizer is initiated and ready to accept a Start trigger and begin sampling. 
        /// Ready for Reference Event  (10) Asserts when the digitizer is ready to accept a Reference trigger. 
        /// Reference Clock  (100) Export the Reference clock for the digitizer to the specified terminal. 
        /// Sample Clock  (101) Export the Sample clock for the digitizer to the specified terminal. 
        /// 
        /// </param>
        /// <param name="Signal_Identifier">
        /// Describes the signal being exported. 
        /// </param>
        /// <param name="Output_Terminal">
        /// Identifies the hardware signal line on which the digital pulse is generated.
        ///  
        /// Defined Values
        /// 
        /// NISCOPE_VAL_RTSI_0  ("VAL_RTSI_0") 
        /// NISCOPE_VAL_RTSI_1 ("VAL_RTSI_1") 
        /// NISCOPE_VAL_RTSI_2 ("VAL_RTSI_2") 
        /// NISCOPE_VAL_RTSI_3  ("VAL_RTSI_3") 
        /// NISCOPE_VAL_RTSI_4 ("VAL_RTSI_4") 
        /// NISCOPE_VAL_RTSI_5  ("VAL_RTSI_5") 
        /// NISCOPE_VAL_RTSI_6 ("VAL_RTSI_6") 
        /// NISCOPE_VAL_RTSI_7 ("VAL_RTSI_7") 
        /// NISCOPE_VAL_PFI_0 ("VAL_PFI_0") 
        /// NISCOPE_VAL_PFI_1 ("VAL_PFI_1") 
        /// NISCOPE_VAL_PFI_2 ("VAL_PFI_2") 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ExportSignal(int Signal, string Signal_Identifier, string Output_Terminal)
        {
            int pInvokeResult = PInvoke.ExportSignal(this._handle, Signal, Signal_Identifier, Output_Terminal);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Configures the custom coefficients for the equalization FIR filter on the device. This filter is designed to compensate the input signal for artifacts introduced to the signal outside of the digitizer. Because this filter is a generic FIR filter, any coefficients are valid. Coefficient values should be between +1 and -1.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel on which to configure the filter. For more information, refer to Channel String Syntax in the NI-SCOPE Function Reference Help.
        /// 
        /// </param>
        /// <param name="Number_Of_Coefficients">
        /// The number of coefficients being passed in the coefficients array. 
        /// </param>
        /// <param name="Coefficients">
        /// The custom coefficients for the equalization FIR filter on the device. These coefficients should be between +1 and -1. 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureEqualizationFilterCoefficients(string Channel_List, int Number_Of_Coefficients, double[] Coefficients)
        {
            int pInvokeResult = PInvoke.ConfigureEqualizationFilterCoefficients(this._handle, Channel_List, Number_Of_Coefficients, Coefficients);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Restores the attribute to its default setup value and clears the authorship of the attribute.
        /// 
        /// Currently supports resetting only NISCOPE_ATTR_MIN_SAMPLE_RATE. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_Name">
        /// The string name of the channel you want to configure; for example, "0" or "1".
        /// </param>
        /// <param name="Attribute_ID">
        /// Pass the ID of an attribute.
        /// 
        /// </param>
        public int ResetAttribute(string Channel_Name, int Attribute_ID)
        {
            int pInvokeResult = PInvoke.ResetAttribute(this._handle, Channel_Name, Attribute_ID);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Aborts an acquisition and returns the digitizer to the Idle state. This function is useful if the digitizer times out waiting for a trigger. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int Abort()
        {
            int pInvokeResult = PInvoke.Abort(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns status information indicating whether an acquisition is in progress, complete, or unknown.  
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Acquisition_Status">
        /// Returns the acquisition status of the digitizer.  Possible values that this parameter returns are:
        /// 
        /// NISCOPE_VAL_ACQ_IN_PROGRESS (0) - The acquisition is in 
        ///    progress
        /// 
        /// NISCOPE_VAL_ACQ_COMPLETE (1) - The acquisition
        ///    is complete.
        /// 
        /// NISCOPE_VAL_ACQ_STATUS_UNKNOWN (-1) - The acquisition is in   
        ///    an unknown state.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int AcquisitionStatus(out int Acquisition_Status)
        {
            int pInvokeResult = PInvoke.AcquisitionStatus(this._handle, out Acquisition_Status);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Commits to hardware all the parameter settings associated with the task. Use this function if you want a parameter change to be immediately reflected in the hardware. This function is only supported for the NI 5122/5124. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int Commit()
        {
            int pInvokeResult = PInvoke.Commit(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the waveform from a previously initiated acquisition that the digitizer acquires for the specified channel. This function returns scaled voltage waveforms.
        /// 
        /// This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify. 
        /// 
        /// Refer to &lt;a href="Using_Fetch_Functions.html"&gt;Using Fetch Functions&lt;/a&gt; for more information on using this function.
        /// 
        /// Note You can use niScope_Read instead of this function. niScope_Read starts an acquisition on all enabled channels, waits for the acquisition to complete, and returns the waveform for the specified channel.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel name that you want to acquire data from, such as "0" or "1".
        /// 
        /// This paramter may also be a list of channels, such as "0,1".  If a list is specified, the array of waveforms is ordered the same as the list.
        /// 
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Num_Samples">
        /// Number of samples to fetch for each record.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms; the number of waveforms can be determined by calling niScope_ActualNumWfms.
        /// 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first; for example, with a channel list of 0,1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int Fetch(string Channel_List, double Timeout, int Num_Samples, double[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.Fetch(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Retrieves data that the digitizer has acquired from a previously initiated acquisition and returns a one-dimensional array of complex, scaled waveforms.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel name that you want to acquire data from, such as "0" or "1".
        /// 
        /// This paramter may also be a list of channels, such as "0,1".  If a list is specified, the array of waveforms is ordered the same as the list.
        /// 
        /// </param>
        /// <param name="Timeout">
        /// The time to wait in seconds for data to be acquired; using 0 for this parameter tells NI-SCOPE to fetch whatever is currently available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform. If the acquisition finishes with fewer points than requested, some devices return partial data if the acquisition finished, was aborted, or a timeout of 0 was used. Use -1 for this parameter if you want to fetch all available samples. The function reads the actual record length and attempts to acquire all available samples. If it fails to complete within the timeout period, the function returns an error.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms. Call niScope_ActualNumWfms to determine the number of waveforms. 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to determine the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchComplex(string Channel_List, double Timeout, int Num_Samples, niComplexNumber[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchComplex(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Retrieves data that the digitizer has acquired from a previously initiated acquisition and returns binary 16-bit waveforms. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel name that you want to acquire data from, such as "0" or "1".
        /// 
        /// This paramter may also be a list of channels, such as "0,1".  If a list is specified, the array of waveforms is ordered the same as the list.
        /// 
        /// </param>
        /// <param name="Timeout">
        /// The time to wait in seconds for data to be acquired; using 0 for this parameter tells NI-SCOPE to fetch whatever is currently available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform. If the acquisition finishes with fewer points than requested, some devices return partial data if the acquisition finished, was aborted, or a timeout of 0 was used. Use -1 for this parameter if you want to fetch all available samples. The function reads the actual record length and attempts to acquire all available samples. If it fails to complete within the timeout period, the function returns an error.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms. Call niScope_ActualNumWfms to determine the number of waveforms. 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to determine the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchComplexBinary16(string Channel_List, double Timeout, int Num_Samples, niComplexNumber16[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchComplexBinary16(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Retrieves data from a previously initiated acquisition. It returns binary 8-bit waveforms. This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform; if the acquisition finishes with fewer points than requested, partial data will be returned.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms; the number of waveforms can be determined by calling niScope_ActualNumWfms.
        /// 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first; for example, with a channel list of 0,1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchBinary8(string Channel_List, double Timeout, int Num_Samples, sbyte[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchBinary8(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Retrieves data from a previously initiated acquisition. It returns binary 16-bit waveforms. This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform; if the acquisition finishes with fewer points than requested, partial data will be returned.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms; the number of waveforms can be determined by calling niScope_ActualNumWfms 
        /// 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first; for example, with a channel list of 0,1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchBinary16(string Channel_List, double Timeout, int Num_Samples, short[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchBinary16(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Retrieves data from a previously initiated acquisition. It returns binary 32-bit waveforms. This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// 
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform; if the acquisition finishes with fewer points than requested, partial data will be returned.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms; the number of waveforms can be determined by calling niScope_ActualNumWfms 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first; for example, with a channel list of 0,1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchBinary32(string Channel_List, double Timeout, int Num_Samples, int[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchBinary32(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Initiates a waveform acquisition. After you call this function, the digitizer leaves the Idle state and waits for a trigger. The digitizer acquires a waveform for each channel you enable with niScope_ConfigureVertical. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int InitiateAcquisition()
        {
            int pInvokeResult = PInvoke.InitiateAcquisition(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Initiates an acquisition, waits for it to complete, and retrieves the data. The process is similar to calling niScope_InitiateAcquisition, niScope_AcquisitionStatus, and niScope_Fetch. The only difference is that by using niScope_Read, you enable all channels specified with channelList before the acquisition; in the other method, you enable the channels with niScope_ConfigureVertical. 
        /// 
        /// This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel that you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Num_Samples">
        /// The maximum number of samples to fetch for each waveform; if the acquisition finishes with fewer points than requested, partial data will be returned.
        /// </param>
        /// <param name="Wfm">
        /// Returns an array whose length is the numSamples times number of waveforms; the number of waveforms can be determined by calling niScope_ActualNumWfms. 
        /// 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first; for example, with a channel list of 0,1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// relativeInitialX-the time from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX-timestamp of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement-the time between points in the acquired waveform in seconds 
        /// actualSamples-the actual number of samples fetched and placed in the waveform array 
        /// gain-the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = (binary data * gain factor) + offset 
        /// 
        /// offset-the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = (binary data * gain factor) + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int Read(string Channel_List, double Timeout, int Num_Samples, double[] Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.Read(this._handle, Channel_List, Timeout, Num_Samples, Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Adds one measurement to the list of processing steps that are completed before the measurement. The processing is added on a per channel basis, and the processing measurements are completed in the same order they are registered. All measurement library parameters--the attributes starting with NISCOPE_ATTR_MEAS--are cached at the time of registering the processing, and this set of parameters is used during the processing step. The processing measurements are streamed, so the result of the first processing step is used as the input for the next step. The processing is done before any other measurements. 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel to which the processing step is added, such as "0" or "1".
        /// 
        /// </param>
        /// <param name="Meas_Function">
        /// The measurement to be added as a processing step.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int AddWaveformProcessing(string Channel_List, int Meas_Function)
        {
            int pInvokeResult = PInvoke.AddWaveformProcessing(this._handle, Channel_List, Meas_Function);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Clears the waveform stats on the channel and measurement you specify. To clear all of the measurements, use NISCOPE_VAL_ALL_MEASUREMENTS in the clearableMeasurementFunction parameter. 
        /// 
        /// Every time a measurement is called, the statistics information is updated, including the min, max, mean, standard deviation, and number of updates. This information is fetched with niScope_FetchWaveformMeasurementStats. The multi-acquisition array measurements are also cleared with this function. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel for the measurements you wish to clear, such as "0" or "1".
        /// 
        /// </param>
        /// <param name="Clearable_Measurement_Function">
        /// The measurement to clear the stats for.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ClearWaveformMeasurementStats(string Channel_List, int Clearable_Measurement_Function)
        {
            int pInvokeResult = PInvoke.ClearWaveformMeasurementStats(this._handle, Channel_List, Clearable_Measurement_Function);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Clears the list of processing steps assigned to the given channel. The processing is added with the niScope_AddWaveformProcessing function, where the processing steps are completed in the same order in which they are registered. The processing measurements are streamed, so the result of the first processing step is used as the input for the next step. The processing is also done before any other measurements
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel for the processing you wish to clear, such as "0" or "1".
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ClearWaveformProcessing(string Channel_List)
        {
            int pInvokeResult = PInvoke.ClearWaveformProcessing(this._handle, Channel_List);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Obtains a waveform from the digitizer and returns the specified measurement array. This function may return multiple waveforms depending on the number of channels, the acquisition type, and the number of records you specify.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel that you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Array_Meas_Function">
        /// The measurement to be performed on the waveform.
        /// </param>
        /// <param name="Meas_Wfm_Size">
        /// The size of each waveform to fetch. Call niScope_ActualMeasWfmSize to find the resulting size of the  array measurement.
        /// 
        /// 
        /// </param>
        /// <param name="Meas_Wfm">
        /// Returns an array whose length is the number of waveforms times measWfmSize; the number of waveforms is determined by calling niScope_ActualNumWfms; the size of each waveform can be determined by calling niScope_ActualMeasWfmSize 
        /// 
        /// NI-SCOPE returns this data sequentially, so all record 0 waveforms are first. For example, with channel list of 0, 1, you would have the following index values: 
        /// 
        /// index 0 = record 0, channel 0 
        /// 
        /// index x = record 0, channel 1 
        /// 
        /// index 2x = record 1, channel 0 
        /// 
        /// index 3x = record 1, channel 1 
        /// 
        /// Where x = the record length
        /// 
        /// </param>
        /// <param name="Wfm_Info">
        /// Returns an array of structures with the following timing and scaling information about each waveform: 
        /// 
        /// relativeInitialX--the time (in seconds) from the trigger to the first sample in the fetched waveform 
        /// absoluteInitialX--timestamp (in seconds) of the first fetched sample that is comparable between records and acquisitions; your digitizer must support continuous acquisition 
        /// xIncrement--the time between points in the acquired waveform in seconds 
        /// actualSamples--the actual number of samples fetched and placed in the waveform array 
        /// gain--the gain factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// offset--the offset factor of the given channel; useful for scaling binary data with this formula 
        /// voltage = binary data * gain factor + offset 
        /// 
        /// Call niScope_ActualNumWfms to find out the size of this array.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchArrayMeasurement(string Channel_List, double Timeout, int Array_Meas_Function, int Meas_Wfm_Size, double[] Meas_Wfm, niScopeWfmInfo[] Wfm_Info)
        {
            int pInvokeResult = PInvoke.FetchArrayMeasurement(this._handle, Channel_List, Timeout, Array_Meas_Function, Meas_Wfm_Size, Meas_Wfm, Wfm_Info);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Fetches a waveform from the digitizer and performs the specified waveform measurement.
        /// 
        /// Many of the measurements use the low, mid, and high reference levels, which ou configure by using the attributes NISCOPE_ATTR_MEAS_CHAN_LOW_REF_LEVEL, NISCOPE_ATTR_MEAS_CHAN_MID_REF_LEVEL, and NISCOPE_ATTR_MEAS_CHAN_HIGH_REF_LEVEL to set each channel differently. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel name that you want to acquire data from, such as "0" or "1".
        /// 
        /// This may also be a list of channels, such as "0,1".  If a list is specified, the array of waveforms is ordered the same as the list.
        /// 
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Scalar_Meas_Function">
        /// The scalar measurement to be performed.
        /// </param>
        /// <param name="Result">
        /// An array of results of the specified scalar measurement that includes waveforms from multiple channels, records, and acquisition types.  For example, if the acquisition type is normal there is one waveform per channel per record.  If you call  the fetch measurement function during a normal acquisition  and the channel string is  "0,1",  the order of the output is:
        /// 
        /// -Index 0: measurement result for record 0,  channel 0,
        /// -Index 1: measurement result for record 0,  channel 1,
        /// -Index 2: measurement result for record 1,  channel 0,
        /// -Index 3: measurement result for record 1,  channel 1,
        /// 
        /// The order of the channels is the order specified by the channel list parameter.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchMeasurement(string Channel_List, double Timeout, int Scalar_Meas_Function, double[] Result)
        {
            int pInvokeResult = PInvoke.FetchMeasurement(this._handle, Channel_List, Timeout, Scalar_Meas_Function, Result);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Obtains a waveform measurement and returns the measurement value. This function may return multiple statistical results depending on the number of channels, the acquisition type, and the number of records you specify. 
        /// 
        /// You specify a particular measurement type, such as rise time, frequency, or voltage peak-to-peak. The waveform on which the digitizer calculates the waveform measurement is from an acquisition that you previously initiated. The statistics for the specified measurement function are returned, where the statistics are updated once every acquisition when the specified measurement is fetched by any of the Fetch Measurement functions. If a Fetch Measurement function has not been called, this function fetches the data on which to perform the measurement. The statistics are cleared by calling niScope_ClearWaveformMeasurementStats. 
        /// 
        /// Many of the measurements use the low, mid, and high reference levels, which you configure with the attributes NISCOPE_ATTR_MEAS_CHAN_LOW_REF_LEVEL, NISCOPE_ATTR_MEAS_CHAN_MID_REF_LEVEL, and NISCOPE_ATTR_MEAS_CHAN_HIGH_REF_LEVEL to set each channel differently. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel that you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Scalar_Meas_Function">
        /// The scalar measurement to be performed on each fetched waveform.
        /// </param>
        /// <param name="Result">
        /// Returns the resulting measurement.
        /// </param>
        /// <param name="Mean">
        /// Returns the mean scalar value, which is obtained by averaging each niScope_FetchMeasurementStats call.
        /// </param>
        /// <param name="Stdev">
        /// Returns the standard deviation of the most recent numInStats measurements.
        /// </param>
        /// <param name="Min">
        /// Returns the smallest scalar value acquired (the minimum of the numInStats measurements)
        /// </param>
        /// <param name="Max">
        /// Returns the largest scalar value acquired (the maximum of the numInStats measurements).
        /// </param>
        /// <param name="Num_In_Stats">
        /// Returns the number of times niScope_FetchMeasurementStats has been called.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchMeasurementStats(string Channel_List, double Timeout, int Scalar_Meas_Function, double[] Result, double[] Mean, double[] Stdev, double[] Min, double[] Max, int[] Num_In_Stats)
        {
            int pInvokeResult = PInvoke.FetchMeasurementStats(this._handle, Channel_List, Timeout, Scalar_Meas_Function, Result, Mean, Stdev, Min, Max, Num_In_Stats);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Initiates an acquisition, waits for it to complete, and performs the specified waveform measurement for a single channel and record or for multiple channels and records.
        /// 
        /// Many of the measurements use the low, mid, and high reference levels, which you configure by using the attributes NISCOPE_ATTR_MEAS_CHAN_LOW_REF_LEVEL, NISCOPE_ATTR_MEAS_CHAN_MID_REF_LEVEL, and NISCOPE_ATTR_MEAS_CHAN_HIGH_REF_LEVEL to set each channel differently.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// The channel that you will acquire data from; it may be a single channel, such as "0" or "1", or a list of channels such as "0,1"
        /// </param>
        /// <param name="Timeout">
        /// Time in seconds that you want to wait for the specified number of samples. A timeout of 0 means return whatever is available.
        /// </param>
        /// <param name="Scalar_Meas_Function">
        /// The scalar measurement to be performed.
        /// </param>
        /// <param name="Result">
        /// Contains an array of all measurements acquired; the array length can be determined by calling niScope_ActualNumWfms.
        /// 
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ReadMeasurement(string Channel_List, double Timeout, int Scalar_Meas_Function, double[] Result)
        {
            int pInvokeResult = PInvoke.ReadMeasurement(this._handle, Channel_List, Timeout, Scalar_Meas_Function, Result);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Self-calibrates the digitizer. Refer to Features Supported by Device to find out if your digitizer supports self-calibration.
        /// 
        /// For the NI 5122/5124, if the self-calibration is performed successfully in a regular session, the calibration constants are immediately stored in the self-calibration area of the EEPROM. If the self-calibration is performed in an external calibration session, the calibration constants take effect immediately for the duration of the session. However, they are not stored in the EEPROM until you call niScope_CalEnd with action set to NISCOPE_VAL_ACTION_STORE, and no errors occur.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel_List">
        /// Pass the channel the reference voltage is connected to.
        /// 
        /// Valid Values: 
        /// 0..n-1,  n is the number of channels on the NI SCOPE device
        /// 
        /// </param>
        /// <param name="Option">
        /// Only NISCOPE_VAL_CAL_RESTORE_EXTERNAL_CALIBRATION is supported; use VI_NULL for a normal self-calibration operation.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int CalSelfCalibrate(string Channel_List, int Option)
        {
            int pInvokeResult = PInvoke.CalSelfCalibrate(this._handle, Channel_List, Option);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Performs a hard reset of the device. Acquisition stops, all routes are released, RTSI and PFI lines are tri-stated, hardware is configured to its default state, and all session attributes are reset to their default state. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ResetDevice()
        {
            int pInvokeResult = PInvoke.ResetDevice(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Aborts any current operation, opens data channel relays, and releases RTSI and PFI lines. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int Disable()
        {
            int pInvokeResult = PInvoke.Disable(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Starts the 1 kHz square wave output on PFI 1 for probe compensation. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ProbeCompensationSignalStart()
        {
            int pInvokeResult = PInvoke.ProbeCompensationSignalStart(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Stops the 1 kHz square wave output on PFI 1 for probe compensation.
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ProbeCompensationSignalStop()
        {
            int pInvokeResult = PInvoke.ProbeCompensationSignalStop(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Resets the instrument to the default state.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int reset()
        {
            int pInvokeResult = PInvoke.reset(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Performs a software reset of the device, returning it to the default state and applying any initial default settings from the IVI Configuration Store. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ResetWithDefaults()
        {
            int pInvokeResult = PInvoke.ResetWithDefaults(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Returns the revision numbers of the instrument driver and instrument firmware.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Driver_Revision">
        /// Returns the instrument driver software revision numbers in the form of a string.
        /// 
        /// You must pass a ViChar array at least 256 bytes in length.
        /// </param>
        /// <param name="Firmware_Revision">
        /// Returns the instrument firmware revision numbers in the form of a string.
        /// 
        /// You must pass a ViChar array at least 256 bytes in length.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int revision_query(System.Text.StringBuilder Driver_Revision, System.Text.StringBuilder Firmware_Revision)
        {
            int pInvokeResult = PInvoke.revision_query(this._handle, Driver_Revision, Firmware_Revision);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Runs the instrument's self-test routine and returns the test result(s). 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Self_Test_Result">
        /// Contains the value returned from the instrument self-test.  
        /// 
        /// Self-Test Code    Description
        /// ---------------------------------------
        ///    0              Self-test passed
        ///    1              Self-test failed
        /// 
        /// </param>
        /// <param name="Self_Test_Message">
        /// Returns the self-test response string from the instrument. 
        /// 
        /// You must pass a ViChar array at least 256 bytes in length.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int self_test(out short Self_Test_Result, System.Text.StringBuilder Self_Test_Message)
        {
            int pInvokeResult = PInvoke.self_test(this._handle, out Self_Test_Result, Self_Test_Message);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// Takes the error code returned by NI-SCOPE functions and returns the interpretation as a user-readable string. 
        /// 
        /// Note  You can pass VI_NULL as the instrument handle, which is useful to interpret errors after niScope_init has failed.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Error_Code">
        /// Pass the Error Code that is returned from any of the instrument driver functions.
        /// </param>
        /// <param name="Error_Source">
        /// Returns the name of the function where the error was generated.
        /// 
        /// You must pass a ViChar array at least MAX_FUNCTION_NAME_SIZE bytes in length.
        /// 
        /// </param>
        /// <param name="Error_Description">
        /// Returns the interpreted Error Code as a user readable message string.
        /// 
        /// You must pass a ViChar array at least MAX_ERROR_DESCRIPTION bytes in length.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int errorHandler(int Error_Code, System.Text.StringBuilder Error_Source, System.Text.StringBuilder Error_Description)
        {
            int pInvokeResult = PInvoke.errorHandler(this._handle, Error_Code, Error_Source, Error_Description);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the most commonly configured attributes of the instrument acquisition subsystem.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Time_per_Record">
        /// Specifies the time per record.
        /// 
        /// Units: Seconds.
        /// </param>
        /// <param name="Min_Num_Points">
        /// Pass the minimum number of points you require in the record for each channel.  Call niScope_ActualRecordLength to obtain the actual record length used.
        /// 
        /// Valid Values:  1 - available onboard memory
        /// 
        /// </param>
        /// <param name="Acquisition_Start_Time">
        /// Specifies the position of the first point in the waveform record relative to the trigger event.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureAcquisitionRecord(double Time_per_Record, int Min_Num_Points, double Acquisition_Start_Time)
        {
            int pInvokeResult = PInvoke.ConfigureAcquisitionRecord(this._handle, Time_per_Record, Min_Num_Points, Acquisition_Start_Time);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the most commonly configured attributes of the istrument's channel subsystem.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel">
        /// Specifies the channel(s) to be configured.
        /// 
        /// Default Value: "0"
        /// 
        /// Valid Range:   "0"
        ///                "1"
        ///                "0,1"
        ///                "1,0"
        ///                ""
        /// </param>
        /// <param name="Range">
        /// Specifies the voltage range for the specified channel(s).
        /// </param>
        /// <param name="Offset">
        /// Selects the DC offset added to the specified channel(s).
        /// 
        /// Default Value: 0
        /// </param>
        /// <param name="Coupling">
        /// Specify how you want the digitizer to couple the input signal for the channel.  
        /// 
        /// Valid Values:
        ///   NISCOPE_VAL_AC  - AC Coupling
        ///   NISCOPE_VAL_DC  - DC Coupling
        ///   NISCOPE_VAL_GND - GND Coupling
        /// 
        /// NOTE: A certain amount of delay is required for the coupling capacitor to charge after changing vertical coupling from DC to AC.  This delay is typically:
        ///    Low Impedance Source - 150 ms
        ///    10X Probe            - 1.5 s
        ///    100X Probe           - 15 s
        /// </param>
        /// <param name="Probe_Attenuation">
        /// Specifies the probe attenuation for the specified channel(s).
        /// 
        /// Default Value: 1.00
        /// 
        /// Valid Range:   1.00 - 100
        /// 
        /// Notes:
        /// (1) If you have a probe with yX attenuation, set this parameter to y. For example, a value of 10 would be entered for a 10X probe.
        /// </param>
        /// <param name="Enabled">
        /// Specify whether to enable the digitizer to acquire data for the channel when you call niScope_InitiateAcquisition.
        /// 
        /// Valid Values:
        /// NISCOPE_VI_TRUE  (1) - Acquire data on this channel
        /// NISCOPE_VI_FALSE (0) - Don't acquire data on this channel
        /// 
        /// Default Value:
        /// NISCOPE_VI_TRUE (1)
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureChannel(string Channel, double Range, double Offset, int Coupling, double Probe_Attenuation, bool Enabled)
        {
            int pInvokeResult = PInvoke.ConfigureChannel(this._handle, Channel, Range, Offset, Coupling, Probe_Attenuation, System.Convert.ToUInt16(Enabled));
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Sets the edge triggering attributes. An edge trigger occurs when the trigger signal specified with the source parameter passes through the voltage threshold specified with the level parameter and has the slope specified with the slope parameter.
        /// 
        /// This function affects instrument behavior only if the triggerType is NISCOPE_VAL_EDGE.  Set the trigger type and trigger coupling before calling this function.
        /// 
        /// If the trigger source is one of the analog input channels, you must configure the vertical range, vertical offset, vertical coupling, probe attenuation, and the maximum input frequency before calling this function.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Source">
        /// Pass the source you want the instrument to monitor for a trigger.  
        /// 
        /// Valid Values: 
        /// 
        /// "0",                     - Channel 0
        /// "1",                     - Channel 1
        /// NISCOPE_VAL_EXTERNAL     - Analog External Trigger Input
        /// 
        /// </param>
        /// <param name="Level">
        /// Pass the voltage threshold you want the instrument to use for edge triggering.  
        /// 
        /// The digitizer triggers when the trigger signal passes through the threshold you specify with this parameter and has the slope you specify with the Slope parameter.
        /// 
        /// Units:  volts
        /// </param>
        /// <param name="Slope">
        /// Specify whether you want a rising edge or a falling edge passing through the Trigger Level to trigger the instrument.  
        /// 
        /// Defined Values:
        ///   NISCOPE_VAL_POSITIVE - Rising edge
        ///   NISCOPE_VAL_NEGATIVE - Falling edge
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureEdgeTriggerSource(string Source, double Level, int Slope)
        {
            int pInvokeResult = PInvoke.ConfigureEdgeTriggerSource(this._handle, Source, Level, Slope);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the common attributes of the trigger subsystem.
        /// 
        /// When you use niScope_ReadWaveform, the instrument waits for a trigger. You specify the type of trigger for which the instrument waits with the Trigger Type parameter.
        /// 
        /// If the instrument reauires multiple waveform acquisitions to build a complete waveform, it waits for the length of time you specify with the Holdoff parameter to elapse since the previous trigger. The instrument then waits for the next trigger.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Trigger_Type">
        /// Specifies the type of trigger for which the instrument will wait.
        /// </param>
        /// <param name="Holdoff">
        /// Specifies the trigger holdoff, which is the length of time that will elapse before the instrument waits for the next trigger.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTrigger(int Trigger_Type, double Holdoff)
        {
            int pInvokeResult = PInvoke.ConfigureTrigger(this._handle, Trigger_Type, Holdoff);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Sets the trigger coupling attribute.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Coupling">
        /// Specify how you want the instrument to couple the trigger signal.  
        /// 
        /// Defined Values:
        ///   NISCOPE_VAL_AC - AC coupling
        ///   NISCOPE_VAL_DC - DC coupling
        ///   NISCOPE_VAL_HF_REJECT - High Frequency Reject
        ///   NISCOPE_VAL_LF_REJECT - Low Frequency Reject
        ///   NISCOPE_VAL_AC_PLUS_HF_REJECT - AC coupling and High Frequency  Reject
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTriggerCoupling(int Coupling)
        {
            int pInvokeResult = PInvoke.ConfigureTriggerCoupling(this._handle, Coupling);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the TV line upon which the instrument triggers. The line number is absolute and not relative to the field of the TV signal.
        /// 
        /// This function affects instrument behavior only if the trigger type is set to NISCOPE_VAL_TV_TRIGGER  and the TV trigger event is set to  NISCOPE_VAL_TV_EVENT_LINE_NUMBER. Call  niScope_ConfigureTVTriggerSource  to set the TV trigger event before calling this function.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Line_Number">
        /// Specify the line number of the signal you want to trigger off of. The valid ranges of the attribute depend on the signal format configured. NTSC has valid ranges of 1 to 525.  PAL and SECAM have valid ranges from 1 to 625.
        /// 
        /// Default Value: 1
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTVTriggerLineNumber(int Line_Number)
        {
            int pInvokeResult = PInvoke.ConfigureTVTriggerLineNumber(this._handle, Line_Number);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the instrument for TV triggering. It configures the TV signal format, the event,  and the signal polarity.
        /// 
        /// This function affects instrument behavior only if the trigger type is NISCOPE_VAL_TV_TRIGGER. Set the trigger type and trigger coupling before calling this function.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Source">
        /// Pass the source you want the digitizer to monitor for a trigger.  
        /// 
        /// Valid Values: 
        /// 
        /// "0",                     - Channel 0
        /// "1",                     - Channel 1
        /// NISCOPE_VAL_EXTERNAL     - Analog External Trigger Input
        /// 
        /// </param>
        /// <param name="Signal_Format">
        /// Specify the Video/TV signal format.
        /// 
        ///  Valid Values:
        /// 
        ///  NISCOPE_VAL_NTSC  (1)
        ///  NISCOPE_VAL_PAL   (2) 
        ///  NISCOPE_VAL_SECAM (3) 
        /// </param>
        /// <param name="Event">
        /// Video/TV event to trigger off of.
        /// 
        ///   Valid Values:
        /// 
        ///   NISCOPE_VAL_TV_EVENT_FIELD1 (1) - trigger on field 1 of the signal
        ///   NISCOPE_VAL_TV_EVENT_FIELD2 (2) - trigger on field 2 of the signal
        ///   NISCOPE_VAL_TV_EVENT_ANY_FIELD (3) - trigger on the first field acquired
        ///   NISCOPE_VAL_TV_EVENT_ANY_LINE (4) - trigger on the first line acquired
        ///   NISCOPE_VAL_TV_EVENT_LINE_NUMBER (5) - trigger on a specific line of a video signal.  Valid values vary depending on the signal format configured.
        /// </param>
        /// <param name="Polarity">
        /// Specify the polarity of the video signal to trigger off of.
        ///   
        ///  Valid Values:
        /// 
        ///  NISCOPE_VAL_TV_POSITIVE (1)
        ///  NISCOPE_VAL_TV_NEGATIVE (2)
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ConfigureTVTriggerSource(string Source, int Signal_Format, int Event, int Polarity)
        {
            int pInvokeResult = PInvoke.ConfigureTVTriggerSource(this._handle, Source, Signal_Format, Event, Polarity);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Sends a command to trigger the digitizer. You can configure the type of software trigger to send with the Trigger Name property.  Call this function after you call niScope_ConfigureTriggerSoftware. 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int SendSWTrigger()
        {
            int pInvokeResult = PInvoke.SendSWTrigger(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Clears the list of current interchange warnings.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ClearInterchangeWarnings()
        {
            int pInvokeResult = PInvoke.ClearInterchangeWarnings(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Returns the interchangeability warnings associated with the IVI session. It retrieves and clears the oldest instance in which the class driver recorded an interchangeability warning. Interchangeability warnings indicate that using your application with a different instrument might cause different behavior. 
        /// Use this function to retrieve interchangeability warnings. The driver performs interchangeability checking when NISCOPE_ATTR_INTERCHANGE_CHECK is set to VI_TRUE. The function returns an empty string in the Interchange Warning parameter if no interchangeability warnings remain for the session. 
        /// In general, the instrument driver generates interchangeability warnings when an attribute that affects the behavior of the instrument is in a state that you did not specify.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Buffer_Size">
        /// Passes the number of bytes in the ViChar array you specify for the Description parameter. 
        /// If the error description, including the terminating NULL byte, contains more bytes than you indicate in this parameter, the function copies BufferSize - 1 bytes into the buffer, places an ASCII NULL byte at the end of the buffer, and returns the buffer size you must pass to get the entire value. For example, if the value is "123456" and the Buffer Size is 4, the function places "123" into the buffer and returns 7. 
        /// If you pass a negative number, the function copies the value to the buffer regardless of the number of bytes in the value. 
        /// If you pass 0, you can pass VI_NULL for the Description buffer parameter. 
        /// 
        /// </param>
        /// <param name="Interchange_Warning">
        /// Returns the next interchange warning for the IVI session. If there are no interchange warnings, the function returns an empty string. The buffer must contain at least as many elements as the value you specify with the Buffer Size parameter. 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int GetNextInterchangeWarning(int Buffer_Size, System.Text.StringBuilder Interchange_Warning)
        {
            int pInvokeResult = PInvoke.GetNextInterchangeWarning(this._handle, Buffer_Size, Interchange_Warning);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// When developing a complex test system that consists of multiple test modules, it is generally a good idea to design the test modules so that they can run in any order. To do so requires ensuring that each test module completely configures the state of each instrument it uses. 
        /// 
        /// If a particular test module does not completely configure the state of an instrument, the state of the instrument depends on the configuration from a previously executed test module. 
        /// If you execute the test modules in a different order, the behavior of the instrument and therefore the entire test module is likely to change. 
        /// 
        /// This change in behavior is generally instrument-specific and represents an interchangeability problem. You can use this function to test for such cases. After you call this function, the interchangeability checking algorithms in the specific driver ignore all previous configuration operations. 
        /// By calling this function at the beginning of a test module, you can determine whether the test module has dependencies on the operation of previously executed test modules. 
        /// 
        /// This function does not clear the interchangeability warnings from the list of previously recorded interchangeability warnings. If you want to guarantee that niScope_GetNextInterchangeWarning only returns those interchangeability warnings that are generated after calling this function, you must clear the list of interchangeability warnings. 
        /// 
        /// You can clear the interchangeability warnings list by repeatedly calling niScope_GetNextInterchangeWarning until no more interchangeability warnings are returned. If you are not interested in the content of those warnings, you can call niScope_ClearInterchangeWarnings.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ResetInterchangeCheck()
        {
            int pInvokeResult = PInvoke.ResetInterchangeCheck(this._handle);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Returns the waveform from a previously initiated acquisition that the digitizer  acquires for the channel you specify.  
        /// 
        /// niScope_InitiateAcquisition starts an acquisition on the channels that you enable with niScope_ConfigureVertical.  The digitizer acquires waveforms for the enabled channels concurrently.  You use niScope_AcquisitionStatus to determine when the acquisition is complete.  You must call this function separately for each enabled channel to obtain the waveforms.
        /// 
        /// You can call niScope_ReadWaveform instead of niScope_InitiateAcquisition.  niScope_ReadWaveform starts an acquisition on all enabled channels, waits for the acquisition to complete, and returns the waveform for the channel you specify.  Call this function to obtain the waveforms for each of the remaining channels.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel">
        /// Pass the channel name you want to acquire data from.
        /// 
        /// Valid Channel Names: 
        /// "0".."n-1", n is the number of channels on the NI-SCOPE device
        /// 
        /// </param>
        /// <param name="Waveform_Size">
        /// The number of elements to insert into the Waveform Array.
        /// 
        /// </param>
        /// <param name="Waveform">
        /// Returns the waveform that the digitizer acquires. 
        /// 
        /// Units: volts
        /// 
        /// Notes:
        /// If the digitizer cannot sample a point in the waveform, this function returns an error.
        /// </param>
        /// <param name="Actual_Points">
        /// Indicates the actual number of points the function placed in the Waveform Array.
        /// 
        /// </param>
        /// <param name="Initial_X">
        /// Indicates the time of the first point in the Waveform Array.  The time is relative to the Reference Position.  
        /// 
        /// Units: seconds  
        /// 
        /// For example, if the digitizer acquires the first point in the Waveform Array 1 second before the trigger, this parameter returns the value -1.0.  If the acquisition of the first point occurs at the same time as the trigger, this parameter returns the value 0.0.
        /// </param>
        /// <param name="X_Increment">
        /// Indicates the length of time between points in the Waveform Array.  
        /// 
        /// Units: seconds
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchWaveform(string Channel, int Waveform_Size, double[] Waveform, out int Actual_Points, out double Initial_X, out double X_Increment)
        {
            int pInvokeResult = PInvoke.FetchWaveform(this._handle, Channel, Waveform_Size, Waveform, out Actual_Points, out Initial_X, out X_Increment);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Determines whether a value you pass from the waveform array is invalid. After the read and fetch waveform functions execute, each element in the waveform array contains either a voltage or a value indicating that the instrument could not sample a voltange.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Element_Value">
        /// Pass one of the values from the waveform array returned by the read and fetch waveform functions.
        /// </param>
        /// <param name="Is_Invalid">
        /// Returns whether the element value is a valid voltage or a value indicating that the digitizer could not sample a voltage.
        /// 
        /// Return values:
        ///    VI_TRUE : The element value indicates that the instrument could not sample the voltage.
        /// 
        ///    VI_FALSE : The element value is a valid voltage.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int IsInvalidWfmElement(double Element_Value, out bool Is_Invalid)
        {
            ushort Is_InvalidAsUShort;
            int pInvokeResult = PInvoke.IsInvalidWfmElement(this._handle, Element_Value, out Is_InvalidAsUShort);
            Is_Invalid = System.Convert.ToBoolean(Is_InvalidAsUShort);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Initiates an acquisition on the channels that you enable with  niScope_ConfigureVertical. This  function then waits for the acquisition to complete and returns the waveform for the channel you specify. Call  niScope_FetchWaveform to obtain the waveforms for each of the remaining enabled channels without initiating another acquisition. 
        /// 
        /// Use niScope_ActualRecordLength to determine the required size for the WaveformArray. 
        /// 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel">
        /// Pass the channel name you want to acquire data from.
        /// 
        /// Valid Channel Names: 
        /// "0".."n-1", n is the number of channels on the NI-SCOPE device
        /// 
        /// </param>
        /// <param name="Waveform_Size">
        /// The number of elements to insert into the Waveform Array.
        /// 
        /// 
        /// 
        /// </param>
        /// <param name="MaxTime">
        /// Pass the maximum length of time in which to allow the read waveform operation to complete.    
        /// 
        /// If the operation does not complete within this time interval, the function returns the NISCOPE_ERROR_MAX_TIME_EXCEEDED error code.  When this occurs, you can call niScope_Abort to cancel the read waveform operation and return the digitizer to the idle state.
        /// 
        /// Units: milliseconds
        /// 
        /// Other defined values:
        /// NISCOPE_VAL_MAX_TIME_IMMEDIATE    
        /// NISCOPE_VAL_MAX_TIME_INFINITE
        /// 
        /// Notes:
        /// The Maximum Time parameter affects only this function.  It has no effect on other timeout parameters or attributes.
        /// </param>
        /// <param name="Waveform">
        /// Returns the waveform that the digitizer acquires.
        /// Units: volts
        /// 
        /// Note If the digitizer cannot sample a point in the waveform, this function returns an error.
        /// </param>
        /// <param name="Actual_Points">
        /// Indicates the actual number of points the function placed in the Waveform Array.
        /// 
        /// </param>
        /// <param name="Initial__X">
        /// Indicates the time of the first point in the Waveform Array.  The time is relative to the Reference Position.  
        /// 
        /// Units: seconds  
        /// 
        /// For example, if the digitizer acquires the first point in the Waveform Array 1 second before the trigger, this parameter returns the value -1.0.  If the acquisition of the first point occurs at the same time as the trigger, this parameter returns the value 0.0.
        /// </param>
        /// <param name="X_Increment">
        /// Indicates the length of time between points in the Waveform Array.  
        /// 
        /// Units: seconds
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ReadWaveform(string Channel, int Waveform_Size, int MaxTime, double[] Waveform, out int Actual_Points, out double Initial__X, out double X_Increment)
        {
            int pInvokeResult = PInvoke.ReadWaveform(this._handle, Channel, Waveform_Size, MaxTime, Waveform, out Actual_Points, out Initial__X, out X_Increment);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Fetches a waveform measurement from a specific channel from a previously initiated waveform acquisition. You specify a particular measurement type, such as rise time, frequency, and voltage peak-to-peak. 
        /// 
        /// Note  You can use niScope_ReadWaveformMeasurement instead of this function. niScope_ReadWaveformMeasurement starts an acquisition on all enabled channels, waits for the acquisition to complete, obtains a waveform measurement on the specified channel, and returns the waveform for the specified channel. Call this function separately to obtain any other waveform measurements on a specific channel. 
        /// 
        /// Configure the appropriate reference levels before calling this function. You can configure the low, mid, and high references by  setting the following attributes: 
        /// 
        /// -NISCOPE_ATTR_MEAS_HIGH_REF 
        /// -NISCOPE_ATTR_MEAS_LOW_REF 
        /// -NISCOPE_ATTR_MEAS_MID_REF 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel">
        /// The channel to read the waveform from, such as "0" or "1".
        /// 
        /// </param>
        /// <param name="Meas_Function">
        /// Characteristic of the acquired waveform to be measured
        /// </param>
        /// <param name="Measurement">
        /// The measured value
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int FetchWaveformMeasurement(string Channel, int Meas_Function, out double Measurement)
        {
            int pInvokeResult = PInvoke.FetchWaveformMeasurement(this._handle, Channel, Meas_Function, out Measurement);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Configures the reference levels for all channels of the digitizer. The levels may be set on a per channel basis by setting  NISCOPE_ATTR_MEAS_CHAN_HIGH_REF_LEVEL, NISCOPE_ATTR_MEAS_CHAN_LOW_REF_LEVEL, and NISCOPE_ATTR_MEAS_CHAN_MID_REF_LEVEL 
        /// 
        /// This function configures the reference levels for waveform measurements. Call this function before calling niScope_FetchMeasurement to take a rise time, fall time, width negative, width positive, duty cycle negative, or duty cycle positive measurement.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The instrument handle obtained from niScope_init
        /// </param>
        /// <param name="Low">
        /// Pass the low reference you want the digitizer to use for waveform measurements.
        /// 
        /// Units: Either a percentage or voltage based on NISCOPE_ATTR_MEAS_REF_LEVEL_UNITS. A percentage is calculated with the voltage low and voltage high measurements representing 0% and 100% respectively.
        /// 
        /// Default Value:  10.0
        /// </param>
        /// <param name="Mid">
        /// Pass the mid reference you want the digitizer to use for waveform measurements.
        /// 
        /// Units: Either a percentage or voltage based on NISCOPE_ATTR_MEAS_REF_LEVEL_UNITS. A percentage is calculated with the voltage low and voltage high measurements representing 0% and 100% respectively.
        /// 
        /// Default Value:  50.0
        /// </param>
        /// <param name="High">
        /// Pass the high reference you want the digitizer to use for waveform measurements.
        /// 
        /// Units: Either a percentage or voltage based on NISCOPE_ATTR_MEAS_REF_LEVEL_UNITS. A percentage is calculated with the voltage low and voltage high measurements representing 0% and 100% respectively.
        /// 
        /// Default Value:  90.0
        /// </param>
        /// <returns>
        /// Call niScope_errorHandler to get a text description of the error code.
        /// </returns>
        public int ConfigureRefLevels(double Low, double Mid, double High)
        {
            int pInvokeResult = PInvoke.ConfigureRefLevels(this._handle, Low, Mid, High);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Initiates a new waveform acquisition and returns a specified waveform measurement from a specific channel. 
        /// 
        /// This function initiates an acquisition on the channels that you enable with the niScope_ConfigureVertical function. It then waits for the acquisition to complete, obtains a waveform measurement on the channel you specify, and returns the measurement value. You specify a particular measurement type, such as rise time, frequency, or voltage peak-to-peak. 
        /// 
        /// You can call the niScope_FetchWaveformMeasurement function separately to obtain any other waveform measurement on a specific channel without initiating another acquisition. 
        /// 
        /// You must configure the appropriate reference levels before calling this function. Configure the low, mid, and high references by calling niScope_ConfigureRefLevels or by setting the following attributes: 
        /// 
        /// NISCOPE_ATTR_MEAS_HIGH_REF 
        /// NISCOPE_ATTR_MEAS_LOW_REF 
        /// NISCOPE_ATTR_MEAS_MID_REF 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Channel">
        /// The channel to read the waveform from, such as "0" or "1".
        /// 
        /// </param>
        /// <param name="Meas_Function">
        /// The scalar measurement to perform
        /// </param>
        /// <param name="Max_Time">
        /// Pass the maximum length of time in which to allow the read waveform operation to complete.    
        /// 
        /// If the operation does not complete within this time interval, the VI returns the NISCOPE_ERROR_MAX_TIME_EXCEEDED error code.  When this occurs, you can call niScope_Abort to cancel the read waveform operation and return the digitizer to the idle state.
        /// 
        /// Units: milliseconds
        /// 
        /// Note The Max Time parameter affects only this function.  It has no effect on other timeout parameters or properties.
        /// </param>
        /// <param name="Measurement">
        /// The measured value
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int ReadWaveformMeasurement(string Channel, int Meas_Function, int Max_Time, out double Measurement)
        {
            int pInvokeResult = PInvoke.ReadWaveformMeasurement(this._handle, Channel, Meas_Function, Max_Time, out Measurement);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Returns the coercion information associated with the IVI session. This function retrieves and clears the oldest instance in which the instrument driver coerced a value you specified to another value. 
        /// 
        /// If you set NISCOPE_ATTR_RECORD_COERCIONS to VI_TRUE, NI-SCOPE keeps a list of all coercions it makes on ViInt32 or ViReal64 values that you pass to instrument driver functions. Use this function to retrieve information from that list.
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Buffer_Size">
        /// Passes the number of bytes in the ViChar array you specify for the Description parameter. 
        /// If the error description, including the terminating NULL byte, contains more bytes than you indicate in this parameter, the function copies BufferSize - 1 bytes into the buffer, places an ASCII NULL byte at the end of the buffer, and returns the buffer size you must pass to get the entire value. For example, if the value is "123456" and the Buffer Size is 4, the function places "123" into the buffer and returns 7. 
        /// If you pass a negative number, the function copies the value to the buffer regardless of the number of bytes in the value. 
        /// If you pass 0, you can pass VI_NULL for the Description buffer parameter. 
        /// 
        /// </param>
        /// <param name="Record">
        /// Returns the next coercion record for the IVI session. 
        /// If there are no coercions records, the function returns an empty string. The buffer must contain at least as many elements as the value you specify with the Buffer Size parameter.
        /// 
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int GetNextCoercionRecord(int Buffer_Size, System.Text.StringBuilder Record)
        {
            int pInvokeResult = PInvoke.GetNextCoercionRecord(this._handle, Buffer_Size, Record);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Reads an error code and message from the error queue. National Instruments digitizers do not contain an error queue. Errors are reported as they occur. Therefore, this function does not detect errors; 
        /// 
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Err_Code">
        /// Returns the error code for the session or execution thread. If you pass 0 for the Buffer Size, you can pass VI_NULL for this parameter.
        /// </param>
        /// <param name="Err_Message">
        /// Formats the error code into a user-readable message string. Note: The array must contain at least 256 elements ViChar[256].
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int error_query(out int Err_Code, System.Text.StringBuilder Err_Message)
        {
            int pInvokeResult = PInvoke.error_query(this._handle, out Err_Code, Err_Message);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        /// <summary>
        /// This function is included for compliance with the IviScope Class Specification.
        /// 
        /// Returns the channel string that is in the channel table at an index you specify. Not applicable to National Instruments digitizers.
        /// </summary>
        /// <param name="Instrument_Handle">
        /// The Instrument Handle that you obtain from niScope_init.  The handle identifies a particular instrument's session.
        /// </param>
        /// <param name="Index">
        /// A 1-based index into the channel table.
        /// </param>
        /// <param name="Buffer_Size">
        /// Passes the number of bytes in the ViChar array you specify for the Description parameter. 
        /// If the error description, including the terminating NULL byte, contains more bytes than you indicate in this parameter, the function copies BufferSize - 1 bytes into the buffer, places an ASCII NULL byte at the end of the buffer, and returns the buffer size you must pass to get the entire value. For example, if the value is "123456" and the Buffer Size is 4, the function places "123" into the buffer and returns 7. 
        /// If you pass a negative number, the function copies the value to the buffer regardless of the number of bytes in the value. 
        /// If you pass 0, you can pass VI_NULL for the Description buffer parameter. 
        /// 
        /// </param>
        /// <param name="Channel_String">
        /// Returns the channel string that is in the channel table at the index you specify. Do not modify the contents of the channel string.
        /// </param>
        /// <returns>
        /// Returns the status of the function.
        /// 
        /// To obtain a text description of the status code call niScope_errorHandler.
        /// </returns>
        public int GetChannelName(int Index, int Buffer_Size, System.Text.StringBuilder Channel_String)
        {
            int pInvokeResult = PInvoke.GetChannelName(this._handle, Index, Buffer_Size, Channel_String);
            PInvoke.TestForError(this._handle, pInvokeResult);
            return pInvokeResult;
        }

        public void Dispose()
        {
            this.Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if ((this._disposed == false))
            {
                PInvoke.close(this._handle);
                this._handle = System.IntPtr.Zero;
            }
            this._disposed = true;
        }

        public void SetInt32(niScopeProperties propertyId, string repeatedCapabilityOrChannel, int val)
        {
            PInvoke.TestForError(this._handle, PInvoke.SetAttributeViInt32(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), val));
        }

        public void SetInt32(niScopeProperties propertyId, int val)
        {
            this.SetInt32(propertyId, "", val);
        }

        public int GetInt32(niScopeProperties propertyId, string repeatedCapabilityOrChannel)
        {
            int val;
            PInvoke.TestForError(this._handle, PInvoke.GetAttributeViInt32(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), out val));
            return val;
        }

        public int GetInt32(niScopeProperties propertyId)
        {
            return this.GetInt32(propertyId, "");
        }

        public void SetDouble(niScopeProperties propertyId, string repeatedCapabilityOrChannel, double val)
        {
            PInvoke.TestForError(this._handle, PInvoke.SetAttributeViReal64(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), val));
        }

        public void SetDouble(niScopeProperties propertyId, double val)
        {
            this.SetDouble(propertyId, "", val);
        }

        public double GetDouble(niScopeProperties propertyId, string repeatedCapabilityOrChannel)
        {
            double val;
            PInvoke.TestForError(this._handle, PInvoke.GetAttributeViReal64(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), out val));
            return val;
        }

        public double GetDouble(niScopeProperties propertyId)
        {
            return this.GetDouble(propertyId, "");
        }

        public void SetBoolean(niScopeProperties propertyId, string repeatedCapabilityOrChannel, bool val)
        {
            PInvoke.TestForError(this._handle, PInvoke.SetAttributeViBoolean(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), System.Convert.ToUInt16(val)));
        }

        public void SetBoolean(niScopeProperties propertyId, bool val)
        {
            this.SetBoolean(propertyId, "", val);
        }

        public bool GetBoolean(niScopeProperties propertyId, string repeatedCapabilityOrChannel)
        {
            ushort val;
            PInvoke.TestForError(this._handle, PInvoke.GetAttributeViBoolean(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), out val));
            return System.Convert.ToBoolean(val);
        }

        public bool GetBoolean(niScopeProperties propertyId)
        {
            return this.GetBoolean(propertyId, "");
        }

        public void SetString(niScopeProperties propertyId, string repeatedCapabilityOrChannel, string val)
        {
            PInvoke.TestForError(this._handle, PInvoke.SetAttributeViString(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), val));
        }

        public void SetString(niScopeProperties propertyId, string val)
        {
            this.SetString(propertyId, "", val);
        }

        public string GetString(niScopeProperties propertyId, string repeatedCapabilityOrChannel)
        {
            System.Text.StringBuilder newVal = new System.Text.StringBuilder(512);
            int size = PInvoke.GetAttributeViString(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), 512, newVal);
            if ((size < 0))
            {
                PInvoke.ThrowError(this._handle, size);
            }
            else
            {
                if ((size > 0))
                {
                    newVal.Capacity = size;
                    PInvoke.TestForError(this._handle, PInvoke.GetAttributeViString(this._handle, repeatedCapabilityOrChannel, ((int)(propertyId)), size, newVal));
                }
            }
            return newVal.ToString();
        }

        public string GetString(niScopeProperties propertyId)
        {
            return this.GetString(propertyId, "");
        }

        private class PInvoke
        {

            [DllImport("niScope_32.dll", EntryPoint = "niScope_init", CallingConvention = CallingConvention.StdCall)]
            public static extern int init(string Resource_Name, ushort ID_Query, ushort Reset_Device, out System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_InitWithOptions", CallingConvention = CallingConvention.StdCall)]
            public static extern int InitWithOptions(string Resource_Name, ushort ID_Query, ushort Reset_Device, string Option_String, out System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_AutoSetup", CallingConvention = CallingConvention.StdCall)]
            public static extern int AutoSetup(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureAcquisition", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureAcquisition(System.IntPtr Instrument_Handle, int Acquisition_Type);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureHorizontalTiming", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureHorizontalTiming(System.IntPtr Instrument_Handle, double Min_Sample_Rate, int Min_Num_Pts, double Ref_Position, int Num_Records, ushort Enforce_Realtime);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureChanCharacteristics", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureChanCharacteristics(System.IntPtr Instrument_Handle, string Channel_List, double Input_Impedance, double Max_Input_Frequency);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureVertical", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureVertical(System.IntPtr Instrument_Handle, string Channel_List, double Range, double Offset, int Coupling, double Probe_Attenuation, ushort Enabled);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ActualRecordLength", CallingConvention = CallingConvention.StdCall)]
            public static extern int ActualRecordLength(System.IntPtr Instrument_Handle, out int Record_Length);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ActualNumWfms", CallingConvention = CallingConvention.StdCall)]
            public static extern int ActualNumWfms(System.IntPtr Instrument_Handle, string Channel_List, out int Num_Wfms);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ActualMeasWfmSize", CallingConvention = CallingConvention.StdCall)]
            public static extern int ActualMeasWfmSize(System.IntPtr Instrument_Handle, int Array_Meas_Function, out int Meas_Waveform_Size);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SampleMode", CallingConvention = CallingConvention.StdCall)]
            public static extern int SampleMode(System.IntPtr Instrument_Handle, out int Sample_Mode);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SampleRate", CallingConvention = CallingConvention.StdCall)]
            public static extern int SampleRate(System.IntPtr Instrument_Handle, out double Sample_Rate);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerDigital", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerDigital(System.IntPtr Instrument_Handle, string Trigger_Source, int Slope, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerEdge", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerEdge(System.IntPtr Instrument_Handle, string Trigger_Source, double Level, int Slope, int Trigger_Coupling, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerVideo", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerVideo(System.IntPtr Instrument_Handle, string Trigger_Source, ushort Enable_DC_Restore, int Signal_Format, int Event, int Line_Number, int Polarity, int Trigger_Coupling, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerHysteresis", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerHysteresis(System.IntPtr Instrument_Handle, string Trigger_Source, double Level, double Hysteresis, int Slope, int Trigger_Coupling, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerImmediate", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerImmediate(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerSoftware", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerSoftware(System.IntPtr Instrument_Handle, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerWindow", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerWindow(System.IntPtr Instrument_Handle, string Trigger_Source, double Low_Level, double High_Level, int Window_Mode, int Trigger_Coupling, double Holdoff, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SendSoftwareTriggerEdge", CallingConvention = CallingConvention.StdCall)]
            public static extern int SendSoftwareTriggerEdge(System.IntPtr Instrument_Handle, int Which_Trigger);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_AdjustSampleClockRelativeDelay", CallingConvention = CallingConvention.StdCall)]
            public static extern int AdjustSampleClockRelativeDelay(System.IntPtr Instrument_Handle, double Delay);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureClock", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureClock(System.IntPtr Instrument_Handle, string Input_Clock_Source, string Output_Clock_Source, string Clock_Sync_Pulse_Source, ushort Master_Enabled);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerOutput", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerOutput(System.IntPtr Instrument_Handle, int Trigger_Event, string Trigger_Output);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ExportSignal", CallingConvention = CallingConvention.StdCall)]
            public static extern int ExportSignal(System.IntPtr Instrument_Handle, int Signal, string Signal_Identifier, string Output_Terminal);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureEqualizationFilterCoefficients", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureEqualizationFilterCoefficients(System.IntPtr Instrument_Handle, string Channel_List, int Number_Of_Coefficients, [In, Out] double[] Coefficients);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ResetAttribute", CallingConvention = CallingConvention.StdCall)]
            public static extern int ResetAttribute(System.IntPtr Instrument_Handle, string Channel_Name, int Attribute_ID);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_Abort", CallingConvention = CallingConvention.StdCall)]
            public static extern int Abort(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_AcquisitionStatus", CallingConvention = CallingConvention.StdCall)]
            public static extern int AcquisitionStatus(System.IntPtr Instrument_Handle, out int Acquisition_Status);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_Commit", CallingConvention = CallingConvention.StdCall)]
            public static extern int Commit(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_Fetch", CallingConvention = CallingConvention.StdCall)]
            public static extern int Fetch(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] double[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchComplex", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchComplex(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] niComplexNumber[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchComplexBinary16", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchComplexBinary16(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] niComplexNumber16[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchBinary8", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchBinary8(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] sbyte[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchBinary16", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchBinary16(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] short[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchBinary32", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchBinary32(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] int[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_InitiateAcquisition", CallingConvention = CallingConvention.StdCall)]
            public static extern int InitiateAcquisition(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_Read", CallingConvention = CallingConvention.StdCall)]
            public static extern int Read(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Num_Samples, [In, Out] double[] Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_AddWaveformProcessing", CallingConvention = CallingConvention.StdCall)]
            public static extern int AddWaveformProcessing(System.IntPtr Instrument_Handle, string Channel_List, int Meas_Function);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ClearWaveformMeasurementStats", CallingConvention = CallingConvention.StdCall)]
            public static extern int ClearWaveformMeasurementStats(System.IntPtr Instrument_Handle, string Channel_List, int Clearable_Measurement_Function);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ClearWaveformProcessing", CallingConvention = CallingConvention.StdCall)]
            public static extern int ClearWaveformProcessing(System.IntPtr Instrument_Handle, string Channel_List);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchArrayMeasurement", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchArrayMeasurement(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Array_Meas_Function, int Meas_Wfm_Size, [In, Out] double[] Meas_Wfm, [In, Out] niScopeWfmInfo[] Wfm_Info);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchMeasurement", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchMeasurement(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Scalar_Meas_Function, [In, Out] double[] Result);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchMeasurementStats", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchMeasurementStats(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Scalar_Meas_Function, [In, Out] double[] Result, [In, Out] double[] Mean, [In, Out] double[] Stdev, [In, Out] double[] Min, [In, Out] double[] Max, [In, Out] int[] Num_In_Stats);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ReadMeasurement", CallingConvention = CallingConvention.StdCall)]
            public static extern int ReadMeasurement(System.IntPtr Instrument_Handle, string Channel_List, double Timeout, int Scalar_Meas_Function, [In, Out] double[] Result);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_CalSelfCalibrate", CallingConvention = CallingConvention.StdCall)]
            public static extern int CalSelfCalibrate(System.IntPtr Instrument_Handle, string Channel_List, int Option);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ResetDevice", CallingConvention = CallingConvention.StdCall)]
            public static extern int ResetDevice(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_Disable", CallingConvention = CallingConvention.StdCall)]
            public static extern int Disable(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ProbeCompensationSignalStart", CallingConvention = CallingConvention.StdCall)]
            public static extern int ProbeCompensationSignalStart(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ProbeCompensationSignalStop", CallingConvention = CallingConvention.StdCall)]
            public static extern int ProbeCompensationSignalStop(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_reset", CallingConvention = CallingConvention.StdCall)]
            public static extern int reset(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ResetWithDefaults", CallingConvention = CallingConvention.StdCall)]
            public static extern int ResetWithDefaults(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_revision_query", CallingConvention = CallingConvention.StdCall)]
            public static extern int revision_query(System.IntPtr Instrument_Handle, System.Text.StringBuilder Driver_Revision, System.Text.StringBuilder Firmware_Revision);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_self_test", CallingConvention = CallingConvention.StdCall)]
            public static extern int self_test(System.IntPtr Instrument_Handle, out short Self_Test_Result, System.Text.StringBuilder Self_Test_Message);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_errorHandler", CallingConvention = CallingConvention.StdCall)]
            public static extern int errorHandler(System.IntPtr Instrument_Handle, int Error_Code, System.Text.StringBuilder Error_Source, System.Text.StringBuilder Error_Description);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureAcquisitionRecord", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureAcquisitionRecord(System.IntPtr Instrument_Handle, double Time_per_Record, int Min_Num_Points, double Acquisition_Start_Time);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureChannel", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureChannel(System.IntPtr Instrument_Handle, string Channel, double Range, double Offset, int Coupling, double Probe_Attenuation, ushort Enabled);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureEdgeTriggerSource", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureEdgeTriggerSource(System.IntPtr Instrument_Handle, string Source, double Level, int Slope);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTrigger", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTrigger(System.IntPtr Instrument_Handle, int Trigger_Type, double Holdoff);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTriggerCoupling", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTriggerCoupling(System.IntPtr Instrument_Handle, int Coupling);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTVTriggerLineNumber", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTVTriggerLineNumber(System.IntPtr Instrument_Handle, int Line_Number);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureTVTriggerSource", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureTVTriggerSource(System.IntPtr Instrument_Handle, string Source, int Signal_Format, int Event, int Polarity);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SendSWTrigger", CallingConvention = CallingConvention.StdCall)]
            public static extern int SendSWTrigger(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ClearInterchangeWarnings", CallingConvention = CallingConvention.StdCall)]
            public static extern int ClearInterchangeWarnings(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetNextInterchangeWarning", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetNextInterchangeWarning(System.IntPtr Instrument_Handle, int Buffer_Size, System.Text.StringBuilder Interchange_Warning);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ResetInterchangeCheck", CallingConvention = CallingConvention.StdCall)]
            public static extern int ResetInterchangeCheck(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchWaveform", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchWaveform(System.IntPtr Instrument_Handle, string Channel, int Waveform_Size, [In, Out] double[] Waveform, out int Actual_Points, out double Initial_X, out double X_Increment);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_IsInvalidWfmElement", CallingConvention = CallingConvention.StdCall)]
            public static extern int IsInvalidWfmElement(System.IntPtr Instrument_Handle, double Element_Value, out ushort Is_Invalid);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ReadWaveform", CallingConvention = CallingConvention.StdCall)]
            public static extern int ReadWaveform(System.IntPtr Instrument_Handle, string Channel, int Waveform_Size, int MaxTime, [In, Out] double[] Waveform, out int Actual_Points, out double Initial__X, out double X_Increment);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_FetchWaveformMeasurement", CallingConvention = CallingConvention.StdCall)]
            public static extern int FetchWaveformMeasurement(System.IntPtr Instrument_Handle, string Channel, int Meas_Function, out double Measurement);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ConfigureRefLevels", CallingConvention = CallingConvention.StdCall)]
            public static extern int ConfigureRefLevels(System.IntPtr Instrument_Handle, double Low, double Mid, double High);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_ReadWaveformMeasurement", CallingConvention = CallingConvention.StdCall)]
            public static extern int ReadWaveformMeasurement(System.IntPtr Instrument_Handle, string Channel, int Meas_Function, int Max_Time, out double Measurement);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetNextCoercionRecord", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetNextCoercionRecord(System.IntPtr Instrument_Handle, int Buffer_Size, System.Text.StringBuilder Record);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_error_query", CallingConvention = CallingConvention.StdCall)]
            public static extern int error_query(System.IntPtr Instrument_Handle, out int Err_Code, System.Text.StringBuilder Err_Message);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetChannelName", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetChannelName(System.IntPtr Instrument_Handle, int Index, int Buffer_Size, System.Text.StringBuilder Channel_String);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_close", CallingConvention = CallingConvention.StdCall)]
            public static extern int close(System.IntPtr Instrument_Handle);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_error_message", CallingConvention = CallingConvention.StdCall)]
            public static extern int error_message(System.IntPtr Instrument_Handle, int Error_Code, System.Text.StringBuilder Error_Message_2);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetAttributeViInt32", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetAttributeViInt32(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, out int Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetAttributeViReal64", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetAttributeViReal64(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, out double Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetAttributeViString", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetAttributeViString(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, int Buf_Size, System.Text.StringBuilder Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetAttributeViBoolean", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetAttributeViBoolean(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, out ushort Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetAttributeViSession", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetAttributeViSession(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, out System.IntPtr Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SetAttributeViInt32", CallingConvention = CallingConvention.StdCall)]
            public static extern int SetAttributeViInt32(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, int Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SetAttributeViReal64", CallingConvention = CallingConvention.StdCall)]
            public static extern int SetAttributeViReal64(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, double Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SetAttributeViString", CallingConvention = CallingConvention.StdCall)]
            public static extern int SetAttributeViString(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, string Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SetAttributeViBoolean", CallingConvention = CallingConvention.StdCall)]
            public static extern int SetAttributeViBoolean(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, ushort Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_SetAttributeViSession", CallingConvention = CallingConvention.StdCall)]
            public static extern int SetAttributeViSession(System.IntPtr Instrument_Handle, string Channel_List, int Attribute_ID, System.IntPtr Value);

            [DllImport("niScope_32.dll", EntryPoint = "niScope_GetError", CallingConvention = CallingConvention.StdCall)]
            public static extern int GetError(System.IntPtr Instrument_Handle, out int Error_Code, int Buffer_Size, System.Text.StringBuilder Description);


            public static int TestForError(System.IntPtr handle, int status)
            {
                if ((status < 0))
                {
                    PInvoke.ThrowError(handle, status);
                }
                return status;
            }

            public static int ThrowError(System.IntPtr handle, int code)
            {
                int status;
                int size = PInvoke.GetError(handle, out status, 0, null);
                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                if ((size >= 0))
                {
                    msg.Capacity = size;
                    PInvoke.GetError(handle, out status, size, msg);
                }
                throw new System.Runtime.InteropServices.ExternalException(msg.ToString(), code);
            }
        }
    }

    public class niScopeConstants
    {

        public const int Normal = 0;

        public const int Flexres = 1001;

        public const int Ddc = 1002;

        public const double _1MegOhm = 1000000;

        public const double _50Ohms = 50;

        public const int Ac = 0;

        public const int Dc = 1;

        public const int Gnd = 2;

        public const int NoMeasurement = 4000;

        public const int LastAcqHistogram = 4001;

        public const int MultiAcqVoltageHistogram = 4004;

        public const int MultiAcqTimeHistogram = 4005;

        public const int MultiAcqAverage = 4016;

        public const int FftPhaseSpectrum = 4002;

        public const int FftAmpSpectrumVoltsRms = 4003;

        public const int FftAmpSpectrumDb = 4019;

        public const int PolynomialInterpolation = 4011;

        public const int ArrayIntegral = 4006;

        public const int Derivative = 4007;

        public const int Inverse = 4008;

        public const int MultiplyChannels = 4012;

        public const int AddChannels = 4013;

        public const int SubtractChannels = 4014;

        public const int DivideChannels = 4015;

        public const int ArrayOffset = 4025;

        public const int ArrayGain = 4026;

        public const int TriangleWindow = 4023;

        public const int BlackmanWindow = 4024;

        public const int HammingWindow = 4020;

        public const int HanningWindow = 4009;

        public const int FlatTopWindow = 4010;

        public const int ButterworthFilter = 4017;

        public const int ChebyshevFilter = 4018;

        public const int BesselFilter = 4022;

        public const int WindowedFirFilter = 4021;

        public const int Positive = 1;

        public const int Negative = 0;

        public const string Rtsi0 = "VAL_RTSI_0";

        public const string Rtsi1 = "VAL_RTSI_1";

        public const string Rtsi2 = "VAL_RTSI_2";

        public const string Rtsi3 = "VAL_RTSI_3";

        public const string Rtsi4 = "VAL_RTSI_4";

        public const string Rtsi5 = "VAL_RTSI_5";

        public const string Rtsi6 = "VAL_RTSI_6";

        public const string Pfi0 = "VAL_PFI_0";

        public const string Pfi1 = "VAL_PFI_1";

        public const string Pfi2 = "VAL_PFI_2";

        public const string PxiStar = "VAL_PXI_STAR";

        public const int HfReject = 3;

        public const int LfReject = 4;

        public const int AcPlusHfReject = 1001;

        public const string External = "VAL_EXTERNAL";

        public const int Ntsc = 1;

        public const int Pal = 2;

        public const int Secam = 3;

        public const int MPal = 1001;

        public const int _480i5994FieldsPerSecond = 1010;

        public const int _480i60FieldsPerSecond = 1011;

        public const int _480p5994FramesPerSecond = 1015;

        public const int _480p60FramesPerSecond = 1016;

        public const int _576i50FieldsPerSecond = 1020;

        public const int _576p50FramesPerSecond = 1025;

        public const int _720p50FramesPerSecond = 1031;

        public const int _720p5994FramesPerSecond = 1032;

        public const int _720p60FramesPerSecond = 1033;

        public const int _1080i50FieldsPerSecond = 1040;

        public const int _1080i5994FieldsPerSecond = 1041;

        public const int _1080i60FieldsPerSecond = 1042;

        public const int _1080p24FramesPerSecond = 1045;

        public const int TvPositive = 1;

        public const int TvNegative = 2;

        public const int TvEventField1 = 1;

        public const int TvEventField2 = 2;

        public const int TvEventAnyField = 3;

        public const int TvEventAnyLine = 4;

        public const int TvEventLineNumber = 5;

        public const int EnteringWindow = 0;

        public const int LeavingWindow = 1;

        public const int SoftwareTriggerStart = 0;

        public const int SoftwareTriggerReference = 2;

        public const int SoftwareTriggerArmReference = 1;

        public const int SoftwareTriggerAdvance = 3;

        public const string NoSource = "VAL_NO_SOURCE";

        public const string RtsiClock = "VAL_RTSI_CLOCK";

        public const string PxiClock = "VAL_PXI_CLOCK";

        public const string ClkIn = "VAL_CLK_IN";

        public const string ClkOut = "VAL_CLK_OUT";

        public const int None = 0;

        public const int StartTriggerEvent = 2;

        public const int StopTriggerEvent = 1;

        public const int EndOfAcquisitionEvent = 3;

        public const int EndOfRecordEvent = 4;

        public const string Rtsi7 = "VAL_RTSI_7";

        public const int StartTrigger = 2;

        public const int RefTrigger = 1;

        public const int AdvanceTrigger = 5;

        public const int ReadyForAdvanceEvent = 6;

        public const int ReadyForStartEvent = 7;

        public const int ReadyForRefEvent = 10;

        public const int RefClock = 100;

        public const int SampleClock = 101;

        public const int _5vOut = 13;

        public const int AllMeasurements = 10000;

        public const int Frequency = 2;

        public const int AverageFrequency = 1016;

        public const int FftFrequency = 1008;

        public const int Period = 3;

        public const int AveragePeriod = 1015;

        public const int RiseTime = 0;

        public const int FallTime = 1;

        public const int VoltageRms = 4;

        public const int VoltageCycleRms = 16;

        public const int AcEstimate = 1012;

        public const int FftAmplitude = 1009;

        public const int VoltageAverage = 10;

        public const int VoltageCycleAverage = 17;

        public const int DcEstimate = 1013;

        public const int VoltageMax = 6;

        public const int VoltageMin = 7;

        public const int VoltagePeakToPeak = 5;

        public const int VoltageHigh = 8;

        public const int VoltageLow = 9;

        public const int Amplitude = 15;

        public const int VoltageBase = 1006;

        public const int VoltageTop = 1007;

        public const int VoltageBaseToTop = 1017;

        public const int WidthNeg = 11;

        public const int WidthPos = 12;

        public const int DutyCycleNeg = 13;

        public const int DutyCyclePos = 14;

        public const int Overshoot = 18;

        public const int Preshoot = 19;

        public const int LowRefVolts = 1000;

        public const int MidRefVolts = 1001;

        public const int HighRefVolts = 1002;

        public const int Area = 1003;

        public const int CycleArea = 1004;

        public const int Integral = 1005;

        public const int RiseSlewRate = 1010;

        public const int FallSlewRate = 1011;

        public const int TimeDelay = 1014;

        public const int PhaseDelay = 1018;

        public const int VoltageHistogramMean = 2000;

        public const int VoltageHistogramStdev = 2001;

        public const int VoltageHistogramMedian = 2003;

        public const int VoltageHistogramMode = 2010;

        public const int VoltageHistogramHits = 2004;

        public const int VoltageHistogramNewHits = 2011;

        public const int VoltageHistogramMax = 2005;

        public const int VoltageHistogramMin = 2006;

        public const int VoltageHistogramPeakToPeak = 2002;

        public const int VoltageHistogramMeanPlusStdev = 2007;

        public const int VoltageHistogramMeanPlus2Stdev = 2008;

        public const int VoltageHistogramMeanPlus3Stdev = 2009;

        public const int TimeHistogramMean = 3000;

        public const int TimeHistogramStdev = 3001;

        public const int TimeHistogramMedian = 3003;

        public const int TimeHistogramMode = 3010;

        public const int TimeHistogramHits = 3004;

        public const int TimeHistogramNewHits = 3011;

        public const int TimeHistogramMax = 3005;

        public const int TimeHistogramMin = 3006;

        public const int TimeHistogramPeakToPeak = 3002;

        public const int TimeHistogramMeanPlusStdev = 3007;

        public const int TimeHistogramMeanPlus2Stdev = 3008;

        public const int TimeHistogramMeanPlus3Stdev = 3009;

        public const int SelfCalibration = 0;

        public const int RestoreFactoryCalibration = 2;

        public const int ImmediateTrigger = 6;

        public const int Edge = 1;

        public const int TvTrigger = 5;

        public const int RealTime = 0;

        public const int EquivalentTime = 1;

        public const int Start = 482;

        public const int Pretrigger = 477;

        public const int Trigger = 483;

        public const int ReadPointer = 388;

        public const int Now = 481;

        public const double _75Ohms = 75;

        public const int SingleEnded = 0;

        public const int UnbalancedDifferential = 1;

        public const int Differential = 2;

        public const int _48TapStandard = 0;

        public const int _48TapHanning = 1;

        public const int _16TapHanning = 2;

        public const int _8TapHanning = 3;

        public const int RisExactNumAverages = 1;

        public const int RisMinNumAverages = 2;

        public const int RisIncomplete = 3;

        public const int RisLimitedBinWidth = 5;

        public const int Hysteresis = 1001;

        public const int Digital = 1002;

        public const int Window = 1003;

        public const int SoftwareTrigger = 1004;

        public const string Immediate = "VAL_IMMEDIATE";

        public const string SwTrigFunc = "VAL_SW_TRIG_FUNC";

        public const int AnalogDetectionCircuit = 0;

        public const int DdcOutput = 1;

        public const int Symmetric = 0;

        public const int Asymmetric = 1;

        public const int Even = 0;

        public const int Odd = 1;

        public const int Phase = 0;

        public const int Magnitude = 1;

        public const int Resampler = 2;

        public const int Real = 0;

        public const int Complex = 1;

        public const int ErrorReportingError = 0;

        public const int ErrorReportingWarning = 1;

        public const int ErrorReportingDisabled = 2;
    }

    [StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
    public struct niScopeWfmInfo
    {

        public double AbsoluteInitialX;

        public double RelativeInitialX;

        public double XIncrement;

        public int ActualSamples;

        public double Offset;

        public double Gain;

        public double Reserved1;

        public double Reserved2;
    }

    [StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
    public struct niComplexNumber
    {

        public double Real;

        public double Imaginary;
        
    }
 
    [StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 2)]
    public struct niComplexNumber16
    {

        public short Real;

        public short Imaginary;

    }
    
    public enum niScopeProperties
    {

        /// <summary>
        /// System.Int32
        /// </summary>
        AcquisitionType = 1250101,

        /// <summary>
        /// System.Int32
        /// </summary>
        SampleMode = 1250106,

        /// <summary>
        /// System.Int32
        /// </summary>
        BinarySampleWidth = 1150005,

        /// <summary>
        /// System.Int32
        /// </summary>
        Resolution = 1150102,

        /// <summary>
        /// System.Int32
        /// </summary>
        FetchRelativeTo = 1150077,

        /// <summary>
        /// System.Int32
        /// </summary>
        FetchOffset = 1150078,

        /// <summary>
        /// System.Int32
        /// </summary>
        FetchRecordNumber = 1150079,

        /// <summary>
        /// System.Int32
        /// </summary>
        FetchNumRecords = 1150080,

        /// <summary>
        /// System.Int32
        /// </summary>
        FetchMeasNumSamples = 1150081,

        /// <summary>
        /// System.Double
        /// </summary>
        PointsDone = 1150082,

        /// <summary>
        /// System.Int32
        /// </summary>
        RecordsDone = 1150083,

        /// <summary>
        /// System.Double
        /// </summary>
        Backlog = 1150084,

        /// <summary>
        /// System.Boolean
        /// </summary>
        RisInAutoSetupEnable = 1150106,

        /// <summary>
        /// System.Boolean
        /// </summary>
        ChannelEnabled = 1250005,

        /// <summary>
        /// System.Double
        /// </summary>
        ProbeAttenuation = 1250004,

        /// <summary>
        /// System.Double
        /// </summary>
        VerticalRange = 1250001,

        /// <summary>
        /// System.Double
        /// </summary>
        VerticalOffset = 1250002,

        /// <summary>
        /// System.Int32
        /// </summary>
        VerticalCoupling = 1250003,

        /// <summary>
        /// System.Double
        /// </summary>
        MaxInputFrequency = 1250006,

        /// <summary>
        /// System.Double
        /// </summary>
        InputImpedance = 1250103,

        /// <summary>
        /// System.Int32
        /// </summary>
        ChannelTerminalConfiguration = 1150107,

        /// <summary>
        /// System.Int32
        /// </summary>
        FlexFirAntialiasFilterType = 1150271,

        /// <summary>
        /// System.Double
        /// </summary>
        DigitalGain = 1150307,

        /// <summary>
        /// System.Double
        /// </summary>
        DigitalOffset = 1150308,

        /// <summary>
        /// System.Double
        /// </summary>
        AcquisitionStartTime = 1250109,

        /// <summary>
        /// System.Int32
        /// </summary>
        HorzNumRecords = 1150001,

        /// <summary>
        /// System.Double
        /// </summary>
        HorzTimePerRecord = 1250007,

        /// <summary>
        /// System.Int32
        /// </summary>
        HorzMinNumPts = 1250009,

        /// <summary>
        /// System.Int32
        /// </summary>
        HorzRecordLength = 1250008,

        /// <summary>
        /// System.Double
        /// </summary>
        HorzRecordRefPosition = 1250011,

        /// <summary>
        /// System.Double
        /// </summary>
        MinSampleRate = 1150009,

        /// <summary>
        /// System.Double
        /// </summary>
        HorzSampleRate = 1250010,

        /// <summary>
        /// System.Boolean
        /// </summary>
        HorzEnforceRealtime = 1150004,

        /// <summary>
        /// System.Boolean
        /// </summary>
        RefTrigTdcEnable = 1150096,

        /// <summary>
        /// System.Boolean
        /// </summary>
        AllowMoreRecordsThanMemory = 1150068,

        /// <summary>
        /// System.Boolean
        /// </summary>
        EnableTimeInterleavedSampling = 1150128,

        /// <summary>
        /// System.Int32
        /// </summary>
        PollInterval = 1150100,

        /// <summary>
        /// System.Int32
        /// </summary>
        RisNumAverages = 1150070,

        /// <summary>
        /// System.Int32
        /// </summary>
        RisMethod = 1150071,

        /// <summary>
        /// System.Boolean
        /// </summary>
        _5102AdjustPretriggerSamples = 1150085,

        /// <summary>
        /// System.Int32
        /// </summary>
        TriggerType = 1250012,

        /// <summary>
        /// System.String
        /// </summary>
        TriggerSource = 1250013,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerDelayTime = 1250015,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerHoldoff = 1250016,

        /// <summary>
        /// System.Double
        /// </summary>
        StartToRefTriggerHoldoff = 1150103,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerImpedance = 1150075,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerLevel = 1250017,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerHysteresis = 1150006,

        /// <summary>
        /// System.Int32
        /// </summary>
        TriggerCoupling = 1250014,

        /// <summary>
        /// System.Int32
        /// </summary>
        TriggerSlope = 1250018,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerWindowLowLevel = 1150013,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerWindowHighLevel = 1150014,

        /// <summary>
        /// System.Int32
        /// </summary>
        TriggerWindowMode = 1150012,

        /// <summary>
        /// System.Int32
        /// </summary>
        TvTriggerSignalFormat = 1250201,

        /// <summary>
        /// System.Int32
        /// </summary>
        TvTriggerLineNumber = 1250206,

        /// <summary>
        /// System.Int32
        /// </summary>
        TvTriggerPolarity = 1250204,

        /// <summary>
        /// System.Int32
        /// </summary>
        TvTriggerEvent = 1250205,

        /// <summary>
        /// System.Boolean
        /// </summary>
        EnableDcRestore = 1150093,

        /// <summary>
        /// System.Int32
        /// </summary>
        RefTriggerDetectorLocation = 1150314,

        /// <summary>
        /// System.Double
        /// </summary>
        RefTriggerMinimumQuietTime = 1150315,

        /// <summary>
        /// System.Double
        /// </summary>
        DeviceTemperature = 1150086,

        /// <summary>
        /// System.String
        /// </summary>
        SerialNumber = 1150104,

        /// <summary>
        /// System.String
        /// </summary>
        InputClockSource = 1150002,

        /// <summary>
        /// System.String
        /// </summary>
        OutputClockSource = 1150003,

        /// <summary>
        /// System.String
        /// </summary>
        ClockSyncPulseSource = 1150007,

        /// <summary>
        /// System.String
        /// </summary>
        SampClkTimebaseSrc = 1150087,

        /// <summary>
        /// System.Double
        /// </summary>
        SampClkTimebaseRate = 1150088,

        /// <summary>
        /// System.Int32
        /// </summary>
        SampClkTimebaseDiv = 1150089,

        /// <summary>
        /// System.Double
        /// </summary>
        RefClkRate = 1150090,

        /// <summary>
        /// System.String
        /// </summary>
        ExportedSampleClockOutputTerminal = 1150091,

        /// <summary>
        /// System.Boolean
        /// </summary>
        PllLockStatus = 1151303,

        /// <summary>
        /// System.Int32
        /// </summary>
        OscillatorPhaseDacValue = 1150105,

        /// <summary>
        /// System.Boolean
        /// </summary>
        MasterEnable = 1150008,

        /// <summary>
        /// System.String
        /// </summary>
        AcqArmSource = 1150053,

        /// <summary>
        /// System.String
        /// </summary>
        RecordArmSource = 1150065,

        /// <summary>
        /// System.String
        /// </summary>
        AdvTrigSrc = 1150094,

        /// <summary>
        /// System.String
        /// </summary>
        ExportedAdvanceTriggerOutputTerminal = 1150109,

        /// <summary>
        /// System.String
        /// </summary>
        ReadyForRefEventOutputTerminal = 1150111,

        /// <summary>
        /// System.String
        /// </summary>
        ReadyForStartEventOutputTerminal = 1150110,

        /// <summary>
        /// System.String
        /// </summary>
        ReadyForAdvanceEventOutputTerminal = 1150112,

        /// <summary>
        /// System.String
        /// </summary>
        ArmRefTrigSrc = 1150095,

        /// <summary>
        /// System.Double
        /// </summary>
        SlaveTriggerDelay = 1150046,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerToStarDelay = 1150047,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerToRtsiDelay = 1150048,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerToPfiDelay = 1150049,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerFromStarDelay = 1150050,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerFromRtsiDelay = 1150051,

        /// <summary>
        /// System.Double
        /// </summary>
        TriggerFromPfiDelay = 1150052,

        /// <summary>
        /// System.String
        /// </summary>
        MeasOtherChannel = 1150018,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasHysteresisPercent = 1150019,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasLastAcqHistogramSize = 1150020,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasArrayGain = 1150043,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasArrayOffset = 1150044,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasChanLowRefLevel = 1150038,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasChanMidRefLevel = 1150039,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasChanHighRefLevel = 1150040,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasRefLevelUnits = 1150016,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasPercentageMethod = 1150045,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasPolynomialInterpolationOrder = 1150029,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasInterpolationSamplingFactor = 1150030,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasVoltageHistogramSize = 1150021,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasVoltageHistogramLowVolts = 1150022,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasVoltageHistogramHighVolts = 1150023,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasTimeHistogramSize = 1150024,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasTimeHistogramLowVolts = 1150025,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasTimeHistogramHighVolts = 1150026,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasTimeHistogramLowTime = 1150027,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasTimeHistogramHighTime = 1150028,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasFilterCutoffFreq = 1150031,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasFilterCenterFreq = 1150032,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasFilterWidth = 1150041,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasFilterRipple = 1150033,

        /// <summary>
        /// System.Double
        /// </summary>
        MeasFilterTransientWaveformPercent = 1150034,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasFilterType = 1150035,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasFilterOrder = 1150036,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasFilterTaps = 1150037,

        /// <summary>
        /// System.Int32
        /// </summary>
        MeasFirFilterWindow = 1150042,

        /// <summary>
        /// System.Double
        /// </summary>
        DelayBeforeInitiate = 1151304,

        /// <summary>
        /// System.Boolean
        /// </summary>
        FetchInterleavedData = 1150072,

        /// <summary>
        /// System.Boolean
        /// </summary>
        EnableDither = 1151300,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcEnable = 1151003,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcNcoFrequency = 1151000,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcNcoPhase = 1151001,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcTestSineCosine = 1151072,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcCoordinateConverterInput = 1151073,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcQInputToCoordConverterInput = 1151074,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcSyncoutClkSelect = 1151080,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcTimingNcoPhaseAccumLoad = 1151120,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcTimingNcoClearPhaseAccum = 1151121,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcTimingNcoEnableOffsetFreq = 1151122,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcTimingNcoNumOffsetFreqBits = 1151123,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcTimingNcoCenterFrequency = 1151124,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcTimingNcoPhaseOffset = 1151125,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcResamplerFilterModeSelect = 1151126,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcResamplerBypass = 1151127,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcResamplerOutputPulseDelay = 1151128,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcNcoDivide = 1151129,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcReferenceDivide = 1151130,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcCicDecimation = 1151010,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcCicShiftGain = 1151011,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcDiscriminatorEnabled = 1151020,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorFirDecimation = 1151021,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorFirSymmetry = 1151022,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorFirSymmetryType = 1151023,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorFirNumTaps = 1151024,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorDelay = 1151025,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorFirInputSource = 1151026,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDiscriminatorPhaseMultiplier = 1151027,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcPfirDecimation = 1151030,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcPfirSymmetry = 1151031,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcPfirSymmetryType = 1151032,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcPfirNumTaps = 1151033,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcPfirRealOrComplex = 1151034,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcAgcUpperGainLimit = 1151040,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcAgcLowerGainLimit = 1151041,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcLoopGain0Exponent = 1151042,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcLoopGain0Mantissa = 1151043,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcLoopGain1Exponent = 1151044,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcLoopGain1Mantissa = 1151045,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcThreshold = 1151046,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAgcAverageControl = 1151047,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfbandBypassed = 1151050,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfband1Enabled = 1151051,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfband2Enabled = 1151052,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfband3Enabled = 1151053,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfband4Enabled = 1151054,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcHalfband5Enabled = 1151055,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcAoutParallelOutputSource = 1151070,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcBoutParallelOutputSource = 1151071,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcCombinedDecimation = 1151301,

        /// <summary>
        /// System.Double
        /// </summary>
        SerialDacCalVoltage = 1151302,

        /// <summary>
        /// System.Double
        /// </summary>
        MaxRisRate = 1150074,

        /// <summary>
        /// System.Double
        /// </summary>
        MaxRealTimeSamplingRate = 1150073,

        /// <summary>
        /// System.Int32
        /// </summary>
        OnboardMemorySize = 1150069,

        /// <summary>
        /// System.Boolean
        /// </summary>
        RangeCheck = 1050002,

        /// <summary>
        /// System.Boolean
        /// </summary>
        QueryInstrumentStatus = 1050003,

        /// <summary>
        /// System.Boolean
        /// </summary>
        Cache = 1050004,

        /// <summary>
        /// System.Boolean
        /// </summary>
        Simulate = 1050005,

        /// <summary>
        /// System.Boolean
        /// </summary>
        RecordCoercions = 1050006,

        /// <summary>
        /// System.Boolean
        /// </summary>
        InterchangeCheck = 1050021,

        /// <summary>
        /// System.String
        /// </summary>
        SpecificDriverDescription = 1050514,

        /// <summary>
        /// System.String
        /// </summary>
        SpecificDriverPrefix = 1050302,

        /// <summary>
        /// System.String
        /// </summary>
        SpecificDriverVendor = 1050513,

        /// <summary>
        /// System.String
        /// </summary>
        SpecificDriverRevision = 1050551,

        /// <summary>
        /// System.Int32
        /// </summary>
        SpecificDriverClassSpecMajorVersion = 1050515,

        /// <summary>
        /// System.Int32
        /// </summary>
        SpecificDriverClassSpecMinorVersion = 1050516,

        /// <summary>
        /// System.Int32
        /// </summary>
        ChannelCount = 1050203,

        /// <summary>
        /// System.String
        /// </summary>
        SupportedInstrumentModels = 1050327,

        /// <summary>
        /// System.String
        /// </summary>
        GroupCapabilities = 1050401,

        /// <summary>
        /// System.String
        /// </summary>
        InstrumentManufacturer = 1050511,

        /// <summary>
        /// System.String
        /// </summary>
        InstrumentModel = 1050512,

        /// <summary>
        /// System.String
        /// </summary>
        InstrumentFirmwareRevision = 1050510,

        /// <summary>
        /// System.String
        /// </summary>
        IoResourceDescriptor = 1050304,

        /// <summary>
        /// System.String
        /// </summary>
        LogicalName = 1050305,

        /// <summary>
        /// System.String
        /// </summary>
        DriverSetup = 1050007,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcEnabled = 1150300,

        /// <summary>
        /// System.Int32
        /// </summary>
        DdcDataProcessingMode = 1150304,

        /// <summary>
        /// System.Boolean
        /// </summary>
        FetchInterleavedIqData = 1150311,

        /// <summary>
        /// System.Boolean
        /// </summary>
        DdcFrequencyTranslationEnabled = 1150302,

        /// <summary>
        /// System.String
        /// </summary>
        DdcQSource = 1150310,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcCenterFrequency = 1150303,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcFrequencyTranslationPhaseI = 1150305,

        /// <summary>
        /// System.Double
        /// </summary>
        DdcFrequencyTranslationPhaseQ = 1150306,

        /// <summary>
        /// System.Int32
        /// </summary>
        EqualizationNumCoefficients = 1150312,

        /// <summary>
        /// System.Boolean
        /// </summary>
        EqualizationFilterEnabled = 1150313,

        /// <summary>
        /// System.Int32
        /// </summary>
        OverflowErrorReporting = 1150309,
    }
}
