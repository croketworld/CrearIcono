from transformers import SpeechT5Processor, SpeechT5ForTextToSpeech, SpeechT5HifiGan
import torch, soundfile as sf

repo = "YOUR_USER/speecht5-jerry"
processor = SpeechT5Processor.from_pretrained(repo)
model = SpeechT5ForTextToSpeech.from_pretrained(repo)
vocoder = SpeechT5HifiGan.from_pretrained("microsoft/speecht5_hifigan")

text = "Hello, this is Jerry from the Wild Ducks podcast."
inputs = processor(text=text, return_tensors="pt")

# Example speaker embedding (load or extract from dataset)
import numpy as np
speaker = torch.tensor(np.load("speaker_emb.npy")).unsqueeze(0)

speech = model.generate_speech(
    inputs["input_ids"], speaker_embeddings=speaker, vocoder=vocoder
)
sf.write("jerry_demo.wav", speech.numpy(), 16000)
