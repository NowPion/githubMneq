package com.easypan.entity.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.redis.connection.RedisConnectionFactory;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.data.redis.serializer.RedisSerializer;
import org.springframework.stereotype.Component;

@Configuration
public class RedisConfig<V> {

    @Bean
    public RedisTemplate<String,V> redisTemplate(RedisConnectionFactory factory){
        RedisTemplate<String ,V> template = new RedisTemplate<>();
        template.setConnectionFactory(factory);
        template.setKeySerializer(RedisSerializer.string());
        template.setValueSerializer(RedisSerializer.json());
        template.setHashKeySerializer(RedisSerializer.string());
        template.setValueSerializer(RedisSerializer.json());
        template.afterPropertiesSet();
        return template;
    }

}
