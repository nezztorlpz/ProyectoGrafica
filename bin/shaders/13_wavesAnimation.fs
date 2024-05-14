#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture_diffuse1;
uniform float time;

void main()
{   

    vec2 coordsT = TexCoords;
     coordsT.x += 0.07f * time/4;
     coordsT.y += 0.07f * time/4;

    vec4 texel = texture(texture_diffuse1, coordsT);

    FragColor = texel;
}



