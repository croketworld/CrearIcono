import torch
from diffusers import StableDiffusionPipeline
from PIL import Image

# Configuración
MODEL_PATH = "C:\Users\Croket\Documents\AI\Models\fantassifiedIcons_fantassifiedIconsV20.safetensors"  
PROMPT = "{prompt}"
NEGATIVE_PROMPT = "{negative_prompt},text, watermark, blurry, low quality, extra elements"
OUTPUT_PATH = "icon.png"
WIDTH, HEIGHT = 512, 512
NUM_INFERENCE_STEPS = 20
GUIDANCE_SCALE = 7.5
SEED = 42  # Opcional, para reproducibilidad

# Verificar si CUDA está disponible
device = "cuda" if torch.cuda.is_available() else "cpu"
print(f"Usando dispositivo: {device}")

# Cargar el pipeline desde el checkpoint .safetensors
pipe = StableDiffusionPipeline.from_single_file(
    MODEL_PATH,
    torch_dtype=torch.float16 if device == "cuda" else torch.float32,
    safety_checker=None,  # Opcional: desactivar si no lo necesitas
    use_safetensors=True
)

# Mover el modelo a la GPU
pipe.to(device)

# Habilitar atención eficiente si estás en CUDA (mejora rendimiento)
if device == "cuda":
    pipe.enable_xformers_memory_efficient_attention()  # opcional, requiere instalar xformers
    # Alternativa sin xformers:
    # pipe.enable_attention_slicing()

# Generar semilla fija (opcional)
generator = torch.Generator(device=device).manual_seed(SEED)

# Generar la imagen
with torch.autocast("cuda" if device == "cuda" else "cpu"):
    image = pipe(
        prompt=PROMPT,
        negative_prompt=NEGATIVE_PROMPT,
        width=WIDTH,
        height=HEIGHT,
        num_inference_steps=NUM_INFERENCE_STEPS,
        guidance_scale=GUIDANCE_SCALE,
        generator=generator
    ).images[0]

# Guardar la imagen
image.save(OUTPUT_PATH)
print(f"Icono guardado en: {OUTPUT_PATH}")