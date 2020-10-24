import { Injectable, NgZone } from '@angular/core';
import { SpeechRecognitionService } from './speech-recognition.service';

// interface IWindow extends Window {
//     webkitSpeechRecognition: any;
//     SpeechRecognition: any;
// }

@Injectable()
export class AppService {

    constructor(
        public speechRecognitionService: SpeechRecognitionService
    ) { }

    // private speechRecognitionService: SpeechRecognitionService;

    iniciaReconhecimentoPorVoz() {
        return this.speechRecognitionService.record();
    }

    paraReconhecimentoPorVoz() {
        this.speechRecognitionService.DestroySpeechObject();
    }
}