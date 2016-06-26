close all;
clear all;
clc;
% load imdata_imlabel_all.mat;
% load ConvNN.mat;
% cnet=ConvNN;
% matrix_MQE=zeros(1);
% num_examples=length(imdata);
load train2.mat;
num_examples=length(imdata);
num_epochs=10; 
p=0.005;
ij=0;
tic();
for i=1:num_epochs
    for j=1:num_examples
        ij=ij+1;
        disp(ij);
        idout = -ones(173,1);
        idout(imlabel(j)) = 1;
        input=imdata{j};
        [yC1 yS1 yC2 yS2 output]=func_calc_WB_CNN(input,cnet);
        [errC1, errS1, errC2, errS2, errN, MQE] = func_calc_MQE_CNN(cnet, yC1, yS1, yC2, yS2, output, idout);
        cnet = func_correct_WB_CNN( cnet, input, p, errC1, errS1, errC2,errS2, errN, yC1, yS1, yC2, yS2, output);
        matrix_MQE=[matrix_MQE MQE];
    end
end
toc();
figure(); plot(matrix_MQE);

%% test with learning examples
num_examples=length(imdata);
cnet1=cnet;
correct=0;
result=zeros(num_examples,3); 
num_examples=length(imdata);
for i=1:num_examples
    disp(i);
    output=simCNN(imdata{i},cnet1);
    temp=max(output);
    for j=1:length(output)
        if output(j)==temp
            res1=j;
        end
    end
    result(i,1)=i;
    result(i,2)=res1;
    result(i,3)=imlabel(i);
    if res1==imlabel(i)
        correct=correct+1;
    end
end
disp(result);
percent=correct/num_examples;
disp(percent);

%% test with examples
% load train_ConvNN_260x1272_p0005.mat
% load imdata_imlabel_1444.mat
% cnet1=cnet;
% correct=0;
% result=zeros(num_examples,3); 
% num_examples=length(imdata);
% for i=1:num_examples
%     disp(i);
%     output=simCNN(imdata{i},cnet1);
%     temp=max(output);
%     for j=1:length(output)
%         if output(j)==temp
%             res1=j;
%         end
%     end
%     result(i,1)=i;
%     result(i,2)=res1;
%     result(i,3)=imlabel(i);
%     if res1==imlabel(i)
%         correct=correct+1;
%     end
% end
% disp(result)
% percent=correct/num_examples

