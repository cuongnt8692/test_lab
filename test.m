clear
clc
load train_ConvNN.mat;
load imdata_test.mat
alpha = ['A  '; 'AW '; 'AA '; 'B  '; 'C  '; 'D  '; 'DD '; 'E  '; 'EE '; 'G  '; 'H  '; 'I  '; 'K  '; 'L  '; 'M  '; 'N  '; 'O  '; 'OO '; 'OW '; 'P  '; 'Q  '; 'R  '; 'S  '; 'T  '; 'U  '; 'UW '; 'V  '; 'X  '; 'Y  '; 'a  '; 'aw '; 'aa '; 'b  '; 'd  '; 'dd '; 'e  '; 'ee '; 'g  '; 'h  '; 'i  '; 'k  '; 'm  '; 'n  '; 'q  '; 'r  '; 't  '; 'u  '; 'uw '; 'y  '; 'As '; 'Af '; 'Ar '; 'Ax '; 'Aj '; 'AWs'; 'AWf'; 'AWr'; 'AWx'; 'AWj'; 'AAs'; 'AAf'; 'AAr'; 'AAx'; 'AAj'; 'Es '; 'Ef '; 'Er '; 'Ex '; 'Ej '; 'EEs'; 'EEf'; 'EEr'; 'EEx'; 'EEj'; 'Is '; 'If '; 'Ir '; 'Ix '; 'Ij '; 'Os '; 'Of '; 'Or '; 'Ox '; 'Oj '; 'OOs'; 'OOf'; 'OOr'; 'OOx'; 'OOj'; 'OWs'; 'OWf'; 'OWr'; 'OWx'; 'OWj'; 'Us '; 'Uf '; 'Ur '; 'Ux '; 'Uj '; 'UWs'; 'UWf'; 'UWr'; 'UWx'; 'UWj'; 'Ys '; 'Yf '; 'Yr '; 'Yx '; 'Yj '; 'as '; 'af '; 'ar '; 'ax '; 'aj '; 'aws'; 'awf'; 'awr'; 'awx'; 'awj'; 'aas'; 'aaf'; 'aar'; 'aax'; 'aaj'; 'es '; 'ef '; 'er '; 'ex '; 'ej '; 'ees'; 'eef'; 'eer'; 'eex'; 'eej'; 'is '; 'if '; 'ir '; 'ix '; 'ij '; 'oos'; 'oof'; 'oor'; 'oox'; 'ooj'; 'ows'; 'owf'; 'owr'; 'owx'; 'owj'; 'us '; 'uf '; 'ur '; 'ux '; 'uj '; 'uws'; 'uwf'; 'uwr'; 'uwx'; 'uwj'; 'ys '; 'yf '; 'yr '; 'yx '; 'yj '; '0  '; '2  '; '3  '; '4  '; '5  '; '6  '; '7  '; '8  '; '9  '];
alphabet = cellstr(alpha);
%imlabel_test = [16 38 59 49 133 43 24 39 42 43 39 5 48 158 43 38 23 40 43 39 27 40 37 43 35 114 40 39 84 5 33 110 5 39 41 39 17 30 44 47 37 44 47 110 43 21 47 112 43 38 16 10 113 40 166 168 46 47 142 40];
num_examples=length(imdata);
cnet1=cnet;
correct=0;
result=zeros(num_examples, 2); 
for i=1:num_examples
    disp(i);
    output=simCNN(imdata{i},cnet1);
    temp=max(output);
    for j=1:length(output)
        if output(j)==temp
            res1=j;
        end
    end
    result(i, 1)=i;
    %result(i, 2)=imlabel_test(i);
    result(i, 2)=res1;
end
%disp(result);
for i = 1:num_examples
    a = char(alphabet(result(i, 2)));
    fprintf('%d %s\n', result(i, 2), a);
end