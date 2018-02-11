using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;
using AForge.Video;
using WebCam_Capture;
using System.Drawing;

namespace SysTel_Network.Controller
{
    class cls_capture_pintures
    {
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        private View.Frm_capture_pintures _frm_capture_pinture;
        public cls_capture_pintures(View.Frm_capture_pintures _f_capt_pin) {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _frm_capture_pinture = _f_capt_pin;
            _met_event_click();
            videoSource = new VideoCaptureDevice();
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                _frm_capture_pinture.pictureBoxOutput.Image = null;
                _frm_capture_pinture.pictureBoxOutput.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
                videoSource.NewFrame += videoSource_NewFrame;
                videoSource.Start();
            }
        }
        private void _met_event_click() {
            _frm_capture_pinture.btn_capture_pint.Click += new EventHandler(_met_event_click_btn_capture);
            
        }
        private void _met_event_click_btn_capture(object sender, EventArgs e) {
            videoSource.Stop();
        }
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs){
            _frm_capture_pinture.pictureBoxOutput.Image = null;
            _frm_capture_pinture.pictureBoxOutput.Image = (Bitmap)eventArgs.Frame.Clone();
        }

    }
}
